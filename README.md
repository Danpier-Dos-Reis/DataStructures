# HashTables or Dictionaries

In the .NET Framework we have two ways to use HashTables, simple **Hashtable** in the namespace _System.Collections_ and as generic data structure **Dictionary** in _System.Collections.Generic_ namespace, it is recommended to use Dictionary instead of Hashtable, the working principle of Hashtable and Dictionary is that construct a hash that is index into an array usually using polynomials. Searching in a Hashtable and Dictionary has the complexity of time O(1).

## How does it work?

In a Hashtable we are not going to store values in a chain (they are entered one after the other before or after the previous one) consecutively, although we are going to select the position of a value/var/object/etc using a function called Hash Function.

## Example

* Hash Function

    ![Hask Function](Pictures/Hash%20Function.png 'Hask Function')

* "Slots" refer to the individual positions or locations within the hash table where elements are stored.

    ![Slots](Pictures/SlotsDraw.png 'Slots')

    In this hash function if our Key is equal to "12" or "22" the value will be inserted in the slot 4.

    ![Slots](Pictures/Slot%20Position.png 'Slots')

## Notes

* In C#, you cannot directly modify the hash function of a **Dictionary<TKey, TValue>** or a **Hashtable**. The hash function is determined internally by the system.