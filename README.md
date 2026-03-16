# APBD_task1
Tasks from lesson 2

This merge was not fast-forward because I made independent 
changes in the main branch while working on the feature-max branch.
Since the histories diverged, Git had to create a merge commit to bring everything together.


Rebase task

Merge: It keeps the real history. You can see exactly where the branch started and where it joined back. 
       It looks like a "fork" or a loop in the graph.

Rebase: It's a way to keep the history clean. 
        Git takes the commits from my branch and moves them to the very end of the main branch.

I got a conflict because I changed the same line of code in two different branches.
To fix it, I opened Program.cs, found the markers and manually deleted the version I didn't need.