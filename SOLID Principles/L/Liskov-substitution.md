## L - Liskov substitution principle

> "Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program." See also design by contract.


- Substitutability is a principle in object-oriented programming stating that, in a computer program, if S is a subtype of T, then objects of type T may be replaced with objects of type S (i.e., an object of type T may be substituted with any object of a subtype S) without altering any of the desirable properties of the program (correctness, task performed, etc.). 
- More formally, the Liskov substitution principle (LSP) is a particular definition of a subtyping relation, called (strong) behavioral subtyping, that was initially introduced by Barbara Liskov in a 1987 conference keynote address titled Data abstraction and hierarchy. It is a semantic rather than merely syntactic relation, because it intends to guarantee semantic interoperability of types in a hierarchy, object types in particular. Barbara Liskov and Jeannette Wing described the principle succinctly in a 1994 paper as follows:
  
  ```
  Subtype Requirement: 

  Let f(x) be a property provable about objects x of type T. 
  Then f(y) should be true for objects y of type S where S is a subtype of T.

  ```