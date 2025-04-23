# Observer Design Pattern

### Type
Behavioral Design Pattern

### What problem it solves?
The Observer pattern solves the problem of maintaining consistency among dependent objects without creating tightly coupled components.

### How it solves the problem?
The pattern works by establishing a publish-subscribe relationship between objects. The subject maintains a list of observers. Observers register themselves to the subject to receive updates. When the subject undergoes changes, it notifies all registered observers. Observers react accordingly based on the notification received.

### Limitations
+ Performance overhead: Frequent notifications can degrade performance when there are many observers.
+ Complex debugging
+ Memory concerns: Observers can accumulate, leading to potential memory leaks if not properly managed.

### Diagram
![Design_Pattern_Observer drawio](https://github.com/user-attachments/assets/e1da6014-4905-467b-ab61-c0f5c0bdc3e2)




