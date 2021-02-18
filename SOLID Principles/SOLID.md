# SOLID Principle

Solid principle has been one of the most accepted Design patterns in developer communities.

The acronym of S O L I D is as follows :

## S - Single-responsibility principle
```
A class should only have a single responsibility, that is, only changes to one part of the software's specification should be able to affect the specification of the class.
```

- The single-responsibility principle (SRP) is a computer-programming principle that states that every class in a computer program should have responsibility over a single part of that program's functionality, which it should encapsulate. All of that module, class or function's services should be narrowly aligned with that responsibility.
- Robert C. Martin, the originator of the term, expresses the principle as, "A class should have only one reason to change," although, because of confusion around the word "reason" he more recently stated "This principle is about people."

## O - Open–closed principle
```
"Software entities ... should be open for extension, but closed for modification."
```

- In object-oriented programming, the open–closed principle states "software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification"; that is, such an entity can allow its behaviour to be extended without modifying its source code.
- The name open–closed principle has been used in two ways. Both ways use generalizations (for instance, inheritance or delegate functions) to resolve the apparent dilemma, but the goals, techniques, and results are different.

## L - Liskov substitution principle
```
"Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." See also design by contract.
```

- Substitutability is a principle in object-oriented programming stating that, in a computer program, if S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e., an object of type T may be substituted with any object of a subtype S) without altering any of the desirable properties of the program (correctness, task performed, etc.). 
- More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called (strong) behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy. It is a semantic rather than merely syntactic relation, because it intends to guarantee semantic interoperability of types in a hierarchy, object types in particular. Barbara Liskov and Jeannette Wing described the principle succinctly in a 1994 paper as follows:
  
  ```
  Subtype Requirement: Let {\displaystyle \phi (x)}\phi (x) be a property provable about objects {\displaystyle x}x of type T. Then {\displaystyle \phi (y)}{\displaystyle \phi (y)} should be true for objects {\displaystyle y}y of type S where S is a subtype of T.
  ```

## I - Interface segregation principle
```
"Many client-specific interfaces are better than one general-purpose interface."
```

- In the field of software engineering, the interface-segregation principle (ISP) states that no client should be forced to depend on methods it does not use.
- ISP splits interfaces that are very large into smaller and more specific ones so that clients will only have to know about the methods that are of interest to them. Such shrunken interfaces are also called role interfaces.
- ISP is intended to keep a system decoupled and thus easier to refactor, change, and redeploy. ISP is one of the five SOLID principles of object-oriented design, similar to the High Cohesion Principle of GRASP.

## D - Dependency inversion principle
```
One should "depend upon abstractions, [not] concretions."
```

- In object-oriented design, the dependency inversion principle is a specific form of loosely coupling software modules. When following this principle, the conventional dependency relationships established from high-level, policy-setting modules to low-level, dependency modules are reversed, thus rendering high-level modules independent of the low-level module implementation details. The principle states:
  A. High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces).
  B. Abstractions should not depend on details. Details (concrete implementations) should depend on abstractions.
- By dictating that both high-level and low-level objects must depend on the same abstraction, this design principle inverts the way some people may think about object-oriented programming.
- The idea behind points A and B of this principle is that when designing the interaction between a high-level module and a low-level one, the interaction should be thought of as an abstract interaction between them. This not only has implications on the design of the high-level module, but also on the low-level one: the low-level one should be designed with the interaction in mind and it may be necessary to change its usage interface.
- In many cases, thinking about the interaction in itself as an abstract concept allows the coupling of the components to be reduced without introducing additional coding patterns, allowing only a lighter and less implementation-dependent interaction schema.
- When the discovered abstract interaction schema(s) between two modules is/are generic and generalization makes sense, this design principle also leads to the following dependency inversion coding pattern.


