# Part E — Memory Diagrams: Stack & Heap

---

### Step 1: `Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };`

```text
       STACK                                     HEAP
+-------------------+                   +-----------------------------+
| Variable | Value  |                   | Address: 0x00A1 (Order)     |
|----------|--------|                   +-----------------------------+
|    o1    | 0x00A1 | ----------------> | OrderId: 1                  |
+-------------------+                   | CustomerName: "Ali"         |
                                        | Quantity: 0                 |
                                        | UnitPrice: 0.0m             |
                                        | TotalPrice: 0.0m            |
                                        | IsPaid: false               |
                                        | DiscountPercent: 0.0        |
                                        | ShippingCity: ""            |
                                        | Priority: '\0'              |
                                        | ItemCode: 0L                |
                                        +-----------------------------+
```

**Explanation:** 
A new `Order` object is allocated on the Heap at memory address `0x00A1`, and the reference variable `o1` is allocated on the Stack holding this memory address.

---

### Step 2: `Order o2 = o1;`

```text
       STACK                                     HEAP
+-------------------+                   +-----------------------------+
| Variable | Value  |                   | Address: 0x00A1 (Order)     |
|----------|--------|                   +-----------------------------+
|    o1    | 0x00A1 | ----------------> | OrderId: 1                  |
|    o2    | 0x00A1 | ----------------> | CustomerName: "Ali"         |
+-------------------+                   | Quantity: 0                 |
                                        | UnitPrice: 0.0m             |
                                        | TotalPrice: 0.0m            |
                                        | IsPaid: false               |
                                        | DiscountPercent: 0.0        |
                                        | ShippingCity: ""            |
                                        | Priority: '\0'              |
                                        | ItemCode: 0L                |
                                        +-----------------------------+
```

**Explanation:** 
A new reference variable `o2` is created on the Stack, copying the exact memory address (`0x00A1`) from `o1`; no new object is created on the Heap, and both variables now refer to the exact same instance.

---

### Step 3: `o2.IsPaid = true;`

```text
       STACK                                     HEAP
+-------------------+                   +-----------------------------+
| Variable | Value  |                   | Address: 0x00A1 (Order)     |
|----------|--------|                   +-----------------------------+
|    o1    | 0x00A1 | ----------------> | OrderId: 1                  |
|    o2    | 0x00A1 | ----------------> | CustomerName: "Ali"         |
+-------------------+                   | Quantity: 0                 |
                                        | UnitPrice: 0.0m             |
                                        | TotalPrice: 0.0m            |
                                        | IsPaid: true   <-- [UPDATED]|
                                        | DiscountPercent: 0.0        |
                                        | ShippingCity: ""            |
                                        | Priority: '\0'              |
                                        | ItemCode: 0L                |
                                        +-----------------------------+
```

**Explanation:** 
Modifying `o2.IsPaid` updates the `IsPaid` field directly inside the object at address `0x00A1` on the Heap, so checking `o1.IsPaid` immediately reflects this change because both variables share the same object.

---

## What would be different with structs?

If `Order` were a `struct` (like `Point` from Part C):
1. **No Heap Allocation:** The entire data and all 10 fields would reside directly on the **Stack** inside `o1`, with no heap addresses or pointers involved.
2. **Independent Copy on Assignment:** Executing `Order o2 = o1;` would copy the entire struct byte-by-byte into a separate slot on the Stack for `o2`.
3. **Independent Modification:** Modifying `o2.IsPaid = true;` would only change `o2`'s own copy on the Stack, leaving `o1.IsPaid` completely unchanged (false).
