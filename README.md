﻿# Exercises: C# Intro and Basic Syntax
Problems for exercises and homework for the ["Programming Fundamentals Extended" course @ SoftUni.](https://softuni.bg/courses/programming-fundamentals)

### Problem 1.              
Debit Card Number

Write a program, which receives **4** **integers** on the console and
**prints them** in **4-digit debit card format**. See the examples below
for the appropriate formatting.

### Examples

| Input | Output |
| :---: | :---: |
| 12 433 1 5331 | 0012 0433 0001 5331 |
| 9182 4221 12 3 | 9182 4221 0012 0003 |
| 812 321 123 22 | 0812 0321 0123 0022 |

### Problem 2. Rectangle Area

Write a program, which calculates a **rectangle’s area**, based on its **width** and **height**. The **width** and **height** come as floating point numbers on the console, **formatted to the 2nd character after the decimal point**.

#### Examples

|  Input  | Output |
|:-------:|:------:|
| 2 7     | 14.00  |
| 7 8     | 56.00  |
| 12.33 5 | 61.65  |

### Problem 3. Miles to Kilometers

Write a program, which **converts miles** to **kilometers**. **Format** the output to the **2nd decimal place**.

Note: **1mile == 1.60934 kilometers**

#### Examples

|  Input  | Output |
|:-------:|:------:|
| 60      | 96.56  |
| 1       | 1.61   |
| 52.1113 | 83.86  |

### Problem 4. Beverage Labels

Write a program, which reads a food product **name** , **volume** , **energy content**** per 100ml **and** sugar content per 100ml **. Calculate the** energy **and** sugar content **for the** given volume** and print them on the console in the following format:

- Name – as per the input
- Volume – **integer** , **suffixed** by &quot; **ml**&quot; (e.g. &quot; **220ml**&quot;)
- Energy content – **integer** , **suffixed** by &quot; **kcal**&quot; (e.g. &quot; **500kcal**&quot;)
- Sugar content – **integer** , **suffixed** by &quot; **g**&quot; (e.g. &quot; **30g**&quot;)

### Examples

| **Input** | **Output** |
| --- | --- |
| Nuka-Cola22030070 | 220ml Nuka-Cola:660kcal, 154g sugars |

| **Input** | **Output** |
| --- | --- |
| Ice Cold Nuka-Cola25035065 | 250ml Ice Cold Nuka-Cola:875kcal, 162.5g sugars |

| **Input** | **Output** |
| --- | --- |
| Nuka-Cola Quantum350600140 | 350ml Nuka-Cola Quantum:2100kcal, 490g sugars |

### Problem 5. Character Stats

Write a program, which **displays information** about a video game character. You will receive their **name**, **current health**, **maximum health**, **current energy** and **maximum energy** on separate lines. The **current** values will **always** be valid (**equal or lower** than their respective **max** values). Print them in the format as per the examples.

|        Input       |                                Output                               |
|:------------------:|:-------------------------------------------------------------------:|
| Mayro  5  10 9 10  | Name: Mayro Health: \|\|\|\|\|\|.....\| Energy: \|\|\|\|\|\|\|\|\|\|.\|               |
| Bauser 10 10 10 10 | Name: Bauser Health: \|\|\|\|\|\|\|\|\|\|\|\| Energy: \|\|\|\|\|\|\|\|\|\|\|\|              |
| Loogi 8 20 2 14    | Name: Loogi Health: \|\|\|\|\|\|\|\|\|............\| Energy: \|\|\|............\| |
| Toad 0 5 0 10      | Name: Toad Health: \|.....\| Energy: \|..........\|                     |