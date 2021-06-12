# Create Feature Branch Util
[![GitHub Workflow Status (branch)](https://img.shields.io/github/workflow/status/rpbeukes/CreateFeatureBranchUtil/.NETCore/main)](https://github.com/rpbeukes/CreateFeatureBranchUtil/actions?query=branch%3Amain+) [![GitHub commit activity](https://img.shields.io/github/commit-activity/m/rpbeukes/CreateFeatureBranchUtil)](https://github.com/rpbeukes/CreateFeatureBranchUtil/pulse/monthly) ![GitHub](https://img.shields.io/github/license/rpbeukes/CreateFeatureBranchUtil) ![GitHub forks](https://img.shields.io/github/forks/rpbeukes/CreateFeatureBranchUtil?style=social)

## Why?
Repo structure will look like this:

```
- main
- feature/branchFromMain    
- feature/newBranch
```

In [SourceTree](https://www.sourcetreeapp.com/) it will look like a directory structure which can be collapse/expanded:
```
----main
+----feature
------------branchFromMain
------------newBranch
```

SourceTree Workflow to create a new branch...
- click on the `featue/branchFromMain` branch 
- right click and click rename
- then copy the branch structure - 'feature/branchFromMain'
- click on branch
- paste copied branch name ('feature/branchFromMain) in the textbox
- delete 'branchFromMain' and entre new branch name - 'feature/newBranch'

Would like SourceTree to do all the work, so this small utility tool was created in `dotnetcore` which SourceTree will execute via `Custom Actions`.

## How to use it
Download the EXE from the [build pipeline](https://github.com/rpbeukes/CreateFeatureBranchUtil/actions?query=branch%3Amain+) (sign-in to github), and add it as a Customer Action in SourceTree.

In SourceTree, goto `Tools` > `Options` > `Custom Actions`.

![SourceTree's Custom Actions](./images/customerActions.png)

Click `Add` button and...

![SourceTree's Custom Actions](./images/addCustomeAction.png)

To execute the new Custom Action, goto `Actions` > `Custom Actions` > `Create Feature Branch`

![SourceTree's Custom Actions](./images/executeAction.png)

The utility will run...

![SourceTree's Custom Actions](./images/execution.png)

Here is an example of a branch `test`, which was branched from `stuff`.

![SourceTree's Custom Actions](./images/endResult.png)

## Lastly

Use it…don’t use it :smile:
