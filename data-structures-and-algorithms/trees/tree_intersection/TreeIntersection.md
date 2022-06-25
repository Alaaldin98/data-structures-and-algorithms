# Tree Intersection

Write a function called tree_intersection that takes two binary tree parameters.

Approach & Efficiency
Create a tree intersection method that accepts both binary trees and compares each node in both trees. First, convert each tree to a hashset then using binary trees preorder to add them to the list. Then check for hashset2 contains the same value as hashset1 and add to a new hashset.

#### Time: O(n)
#### Space: O(1)

### Whiteboard
![Tree Intersection](TreeIntersection.jpg)
