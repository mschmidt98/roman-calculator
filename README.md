# Exercise Task: Roman Number Calculator

## Introduction

Welcome. This is my implementation of a roman number calculator written as

✅ WPF (working)  
❌ WinForms (skipped)  
❓ Blazor (not working, see [the blazor paragraph below](#blazor))

This project was supposed to meet the following conditions:

- [x] Allows to enter two roman or numbers
- [x] Show sum as roman representation
- [x] Self-explanatory interface
- [x] Only consider the numbers up to M
- [x] Take substraction rules into account
- [x] Do not consider deviations from the normal form

## Blazor

I would have preferred to hand this project in as a **blazor** project, but for reasons beyond my knowledge the code is not registering that the inputs have changed.  
I even tried to copy some example code for data bindings in blazor into my project, but even those were not executed. I read about some breaking changes happening to blazor between .NET 6 and 8.
Some experiments using `@bind-Value`, as well as `@bind`, `@bind-Value:get` and `:set` as well as just doing some things on the press of a button brought no success.
Because of this, I have decided to use WPF, but left the blazor project in here for transparency reasons.

## Additions

To keep things simple I skipped the usage of dependency injection. This is set up for the blazor project, but currently not in use.

In addition, I've added some tests for the calculation. This required separating the parsing from and to roman from the rest of the business logic. These tests could be extended to include the validation done before.

I hope that this project meets expectations ✨
