# 0x0C. C# - Delegates, Events

## Description
What you should learn from this project:

* What are delegates and how to use them
* What are anonymous methods and how to use them
* What is multicasting
* What is the difference between delegates and interfaces
* What is a callback
* What are events and how to use them
* What is asynchronous programming

---

### [0. Universal health](./0-universal_health/)
* Create a public class called Player with the following:


### [1. Damage delegation](./1-damage_delegation/)
* Based on 0-universal_health, create a delegate CalculateHealth that takes a float amount. Write two methods that follow the prototype of the CalculateHealth delegate:


### [2. Validation](./2-validation/)
* Based on 1-damage_delegation, inside the TakeDamage() and HealDamage() methods, calculate the new value of the Player’s hp but do not set the value of hp in these methods.


### [3. Modified behavior](./3-modified_behavior/)
* Based on 2-validation, outside of the Player class, create an enum Modifier with the values Weak, Base, Strong.


### [4. Check yourself](./4-check_yourself/)
* Based on 3-modified_behavior, outside of the Player class, create a new class CurrentHPArgs that inherits from EventArgs with the following:


### [5. Eventful](./5-eventful/)
* Based on 4-check_yourself, create a new method HPValueWarning inside the Player class:

---

## Author
* **Danny Hollman** - [dannyhollman](https://github.com/dannyhollman)
