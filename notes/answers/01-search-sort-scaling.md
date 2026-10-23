# **01-search-sort-scaling** — questions

### Task 1 — Understand linear search

Open `SearchAlgorithms.cs` and inspect `LinearSearch`.

Before changing anything, answer:

#### 1. What does `i` represent?

*The current index.*

#### 2. When does the method stop early?
*If `values` is null or if a match for `target` is found.*

#### 3. What does `-1` mean?
*No match for `target` was found.*

#### 4. What is the best case?
*`target` is found in the first iteration.*

#### 5. What is the worst case?
*`target` is found on the N:th iteration or not at all.*

#### 6. If the array becomes twice as large, what happens to the worst-case amount of work?
*It becomes double the amount compared to previously.*

### Checkpoint question


#### Explain in one or two sentences why binary search requires ordered data:
*Binary search discards one or the other half of a collection based off the assumption that all values are either greater than or lesser than the looked-at value.*

### Task 6 — Connect behavior to Big-O

#### 1. Why array indexing is treated as **O(1)**;
*The index of the target item is known. Thus, only one operation is required; regardless of the size of the collection. In other words: it is constant.*

#### 2. Why linear search is **O(n)** in the worst case;
***n** is the size of the collection. In the worst case, the target value is at the **n-th** index.*

#### 3. Why binary search is **O(log n)**;
*The question can be answered by asking another question: how many times do I need to divide a collection of size **n** by 2 in order to get a quotient of **1**? This represents the worst case scenario of the algorithm.*

*By definition, the answer to that question is **log₂ n***

#### 4. Why this insertion-sort implementation is **O(n²)** in the worst case.
