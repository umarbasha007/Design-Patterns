## DRY Principle

- DRY , an acronym for **Don't repeat yourself** (*DRY*, or sometimes *do not repeat yourself*) is a principle of software development aimed at reducing repetition of software patterns, replacing it with abstractions or using data normalization to avoid redundancy.
- The DRY principle is stated as "Every piece of knowledge must have a single, unambiguous, authoritative representation within a system". 
- The principle has been formulated by Andy Hunt and Dave Thomas in their book The Pragmatic Programmer.
- They apply it quite broadly to include "database schemas, test plans, the build system, even documentation".
- When the DRY principle is applied successfully, a modification of any single element of a system does not require a change in other logically unrelated elements. Additionally, elements that are logically related all change predictably and uniformly, and are thus kept in sync. 
- Besides using methods and subroutines in their code, Thomas and Hunt rely on code generators, automatic build systems, and scripting languages to observe the DRY principle across layers.
  

### DRY vs WET solutions

  - Violations of **DRY** are typically referred to as **WET** solutions, which is commonly taken to stand for "*write every time*", "*write everything twice*", "*we enjoy typing*" or "*waste everyone's time*". 
  - WET solutions are common in multi-tiered architectures where a developer may be tasked with, for example, adding a comment field on a form in a web application. The text string "comment" might be repeated in the label, the HTML tag, in a read function name, a private variable, database DDL, queries, and so on. 
  - A DRY approach eliminates that redundancy by using frameworks that reduce or eliminate all those editing tasks except the most important ones, leaving the extensibility of adding new knowledge variables in one place.

