# Memento

**Memento is a behavioral design pattern that allows making snapshots of an object's state and restoring it in future.**

The Memento doesn't compromise the internal structure of the object it works with, as well as the data kept inside the snapshots.

## Example

The Memento’s principle can be achieved using serialization, which is quite common in C#. While it’s not the only and the most efficient way to make snapshots of an object’s state, it still allows storing state backups while protecting the originator’s structure from other objects.