# Splitwise — Low Level Design

## Problem Statement

A group of friends go out to explore Chennai. Along the way they rack up expenses — bus tickets, taxi fare, museum tickets, food — and each expense is paid by a different friend, sometimes on behalf of only a subset of the group. Given who paid for what and who it was for, compute how much each person owes or is owed, without hardcoding the group size or requiring manual input.

**Sample input** (`Friends.csv`, `Bills.csv`):
- A spent 100 on snacks for A, B, C, D
- B spent 500 on a taxi for C, D
- D spent 300 on a bus for A, B

**Sample output:**
```
A gives 75
B gets 325
C gives 275
D gives 25
```

## Design

- **`Friend`** — id, name, and a running `settlementAmount`. Whether a friend `gives` or `gets` is derived from the sign of that amount, not stored as separate state.
- **`Bill`** — who paid, the amount, what it was for, and the list of friends it covers. `SettleBill()` credits the payer and debits each covered friend's equal share.
- **`Reader`** — parses `Friends.csv` and `Bills.csv` into a `ReaderDTO` (no hardcoded friend count).
- **`BillUtil` / `FriendUtil`** — drive settlement across all bills and print the final balance per friend.

## Tech

C# / .NET

## How to Run

- Open `SplitWise.sln`, build, and run — input is read from `SplitWise/Input/Friends.csv` and `Bills.csv`.
- To try a different scenario, edit those two CSV files (no code changes needed).
