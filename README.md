# Splitwise — Low Level Design

Expense-splitting system for a group trip: tracks who paid for what, then computes who owes whom and the minimal settlement.

**Tech:** C#

## Problem

A group of friends go out for an outing to explore Chennai. On the trip, they incur various expenses like bus tickets, taxi fare, museum tickets and food. Different expenses are paid by different people, and only some people are part of each expense.

The app tells how much each person owes or is owed — no hardcoded group size, no user input required (sample data lives in code).

**Sample input:**
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
