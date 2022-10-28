# MutationDemo

This repo contains some simple classes to illustrate the value of mutation testing.

The MutationDemoUnitTests.BankAccountTests contains some tests against the BankAccount class.

## Instructions

- Install Stryker for .Net as per its [getting started instructions](https://stryker-mutator.io/docs/stryker-net/getting-started/).
- Open a command prompt in the unit test directory (MutationDemoUnitTests)
- Run Stryker and observe the output by running ``` dotnet stryker -o ```

## Mutation challenges!

1. Kill the statement mutation (but only that mutation!) on _transactions.Add(-1 * amount) in the Spend() method;

2. Extend coverage to the line new ArgumentException("You can't spend 0"), without killing the two mutants on that line!

3. .....Then kill those 2 mutants.

4. Un-comment the commented out tests.  Explain why the equality mutation survives on the AllSpending property.... then kill it!

5. Destroy all remaining mutants!!