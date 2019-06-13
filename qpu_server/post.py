#!/usr/bin/env python3
from pathlib import Path
import pprint
import time

pp = pprint.PrettyPrinter(indent=4)

class Timer: 
    def __enter__(self):
        self.start = time.time()

    def __exit__(self, exc_type, exc_val, exc_tb):
        self.end = time.time()

    def __str__(self): 
        return (f"{self.end - self.start:0.2f} s")


def main(args):
    jobs = { str(f) : f.read_text() for f in args.program }
    print(f"Found {len(jobs)} job(s).")

    if not args.no_check:
        for key, program in jobs.items(): 
            print(f"Checking {key}...")
            t = Timer()
            with t:
                measure = check_program(program, args.shots, args.lattice)
            pp.pprint(measure)
            print(f"Check successfull! [{t}]")
    
    if args.commit:
        send_jobs(jobs, args.email, args.server, args.shots)

def check_program(program, shots, lattice):
    from pyquil import get_qc, Program
    from pyquil.parser import parse_program
    from pyquil.api import local_qvm

    p = parse_program(program)
    start = time.time()
    Program().inst(program)
    end = time.time()
    print(f'INST time: {end-start}')
    with local_qvm():
        qc = get_qc(lattice, as_qvm=True)
        return qc.run_and_measure(p, trials=shots)

def send_jobs(jobs, email, server, shots):
    """ Sends jobs to the server """
    import requests
    import json
    
    for key, program in jobs.items(): 
        print(f"Sending {key}...")
        r = requests.post(server + "/send", data={ 
            'quil': program,
            'email': email,
            'shots': shots
            })
        print(f"Result {r}")
        obj = json.loads(r.text)
        pp.pprint(obj)


if __name__ == "__main__": 
    import argparse
    parse = argparse.ArgumentParser(
            description="Submit a job to the server",
            formatter_class=argparse.ArgumentDefaultsHelpFormatter
            )
    parse.add_argument('email', metavar="EMAIL", 
            help='the email to send the results to')
    parse.add_argument('program', metavar="PROGRAM", type=Path, nargs='+', 
            help='quil program files')
    parse.add_argument('--shots', default=1, type=int, 
            help='number of shots')
    parse.add_argument('--server', default="http://63.110.29.106:80", 
            help='the server to post job to')
    parse.add_argument('--lattice', default="Aspen-4-12Q-A",
            help='the lattice to check against')
    parse.add_argument('--commit', action='store_true', 
            help='send the request to the server')
    parse.add_argument('--no-check', action='store_true', 
            help='do not check the program before sending to server')

    main(parse.parse_args())
