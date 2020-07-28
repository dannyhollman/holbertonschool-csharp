# 0x0B. C# - Interfaces

## Description
What you should learn from this project:

* What is an interface
* What are interfaces used for
* How do interfaces, classes, and structs differ
* What is an abstract class
* How are interfaces different from abstract classes
* How is an interface implemented explicitly
* What is the as keyword and how to use it

---

### [0. Abstract thinking](./0-abstract_thinking/)
* Create an abstract class called Base containing the following:


### [1. User interface](./1-user_interface/)
* Based on 0-abstract_thinking, create an interface called IInteractive.


### [2. Escape room](./2-doors/)
* Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive.


### [3. Interior decorating](./3-decorations/)
* Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable.


### [4. Key collecting](./4-keys/)
* Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable.


### [5. Iterate and act](./5-iterate_act/)
* Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it)


### [6. Better iterating and acting](./6-generic_iteration/)
* Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach.

---

## Author
* **Danny Hollman** - [dannyhollman](https://github.com/dannyhollman)
