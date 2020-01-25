# Contributing to Cohesity PowerShell Module :handshake:

We would love for you to contribute to Cohesity PowerShell Module and help make it even better than it is
today! As a contributor, here are the guidelines we would like you to follow:

 - [Code of Conduct](#coc)
 - [Bug Report](#issue)
 - [Documentation](#doc)
 - [Feature Requests](#feature)
 - [Request more examples](#example)
 - [Submission Guidelines](#submit)
 - [Commit Message Guidelines](#commit)
 - [Contributions Under Repository License](#cla) 

## <a name="coc"></a> Code of Conduct
Help us keep Cohesity PowerShell Module open and inclusive. Please read and follow our [Code of Conduct](#coc-details).


## <a name="issue"></a> Found a Bug? :beetle:
If you find a bug in the source code, you can help us by
[submitting an issue](#submit-issue) to our GitHub Repository. Even better, you can
[submit a Pull Request](#submit-pr) with a fix.

## <a name="doc"></a> Have any suggestions for the Documentation? :bulb:
If you find any discrepancies in our Documentation or you any awesome suggestions for us, report it to us by opening a new issue using the  [Documentation template](https://github.com/chandrashekar-cohesity/cohesity-powershell-module/issues/new?assignees=&labels=&template=---documentation.md&title=) provided in our GitHub repo.


## <a name="feature"></a> Missing a Feature? :star:	
You can *request* a new feature by [submitting an issue](#submit-issue) to our GitHub
Repository. If you would like to *implement* a new feature, please submit an issue with
a proposal for your work first, to be sure that we can use it.
Please consider what kind of change it is:

* For a **Major Feature**, first open an issue and outline your proposal so that it can be
discussed. This will also allow us to better coordinate our efforts, prevent duplication of work,
and help you to craft the change so that it is successfully accepted into the project.
* **Small Features** can be crafted and directly [submitted as a Pull Request](#submit-pr).

## <a name="example"></a> Need more code examples and samples?
Reach out to us [here](https://github.com/chandrashekar-cohesity/cohesity-powershell-module/issues/new?assignees=&labels=&template=issues---sample-requests---questions--.md&title=) if you have any questions or if you want to request more examples and sample code. We would love to help you out!!

## <a name="submit"></a> Submission Guidelines

### <a name="submit-issue"></a> Submitting an Issue

Before you submit an issue, please search the issue tracker, maybe an issue for your problem already exists and the discussion might inform you of workarounds readily available.

We want to fix all the issues as soon as possible, but before fixing a bug we need to reproduce and confirm it. In order to reproduce bugs, we will systematically ask you to provide a minimal reproduction. Having a minimal reproducible scenario gives us a wealth of important information without going back & forth to you with additional questions.

A minimal reproduction allows us to quickly confirm a bug (or point out a coding problem) as well as confirm that we are fixing the right problem.

You can file new issues [here](https://github.com/chandrashekar-cohesity/cohesity-powershell-module/issues/new?assignees=&labels=&template=---bug-report.md&title=).


### <a name="submit-pr"></a> Submitting a Pull Request (PR)
Before you submit your Pull Request (PR) consider the following guidelines:

1. Search [GitHub](https://github.com/cohesity/cohesity-powershell-module/pulls) for an open or closed PR
  that relates to your submission. You don't want to duplicate effort.

1. Be sure that an issue describes the problem you're fixing, or documents the design for the feature you'd like to add.
  Discussing the design up front helps to ensure that we're ready to accept your work.

1. Fork the `cohesity/cohesity-powershell-module` repo.

1. Make your changes in a new git branch:

     ```shell
     git checkout -b my-fix-branch master
     ```

1. Create your patch

1. Follow the [Cmdlet Development Guidelines](https://docs.microsoft.com/en-us/powershell/scripting/developer/cmdlet/cmdlet-development-guidelines?view=powershell-7).


1. Commit your changes using a descriptive commit message 

1. Push your branch to GitHub:

    ```shell
    git push origin my-fix-branch
    ```

1. In GitHub, send a pull request to `cohesity-powershell-module:master`.
* If we suggest changes then:
  * Make the required updates.
  * Re-run the Cohesity PowerShell Module test suites to ensure tests are still passing.
  * Rebase your branch and force push to your GitHub repository (this will update your Pull Request):

    ```shell
    git rebase master -i
    git push -f
    ```

That's it! Thank you for your contribution!

#### After your pull request is merged

After your pull request is merged, you can safely delete your branch and pull the changes
from the main (upstream) repository:

* Delete the remote branch on GitHub either through the GitHub web UI or your local shell as follows:

    ```shell
    git push origin --delete my-fix-branch
    ```

* Check out the master branch:

    ```shell
    git checkout master -f
    ```

* Delete the local branch:

    ```shell
    git branch -D my-fix-branch
    ```

* Update your master with the latest upstream version:

    ```shell
    git pull --ff upstream master
    ```

## <a name="cla"></a> Contributions Under Repository License :memo:


Whenever you make a contribution to a repository containing notice of a license, you license your contribution under the same terms, and you agree that you have the right to license your contribution under those terms. If you have a separate agreement to license your contributions under different terms, such as a contributor license agreement, that agreement will supersede.

Isn't this just how it works already? Yep. This is widely accepted as the norm in the open-source community; it's commonly referred to by the shorthand "inbound=outbound". We're just making it explicit.


## <a name="coc-details"></a> Code of Conduct

As contributors and maintainers of the Cohesity PowerShell Module project, we pledge to respect everyone who contributes by posting issues, updating documentation, submitting pull requests, providing feedback in comments, and any other activities.

Communication through any of Cohesity PowerShell Modules's channels (GitHub, [mailing-list](mailto:cohesity-api-sdks@cohesity.com), Twitter, etc.) must be constructive and never resort to personal attacks, trolling, public or private harassment, insults, or other unprofessional conduct.

We promise to extend courtesy and respect to everyone involved in this project regardless of gender, gender identity, sexual orientation, disability, age, race, ethnicity, religion, or level of experience. We expect anyone contributing to the Cohesity PowerShell Modules project to do the same.

If any member of the community violates this code of conduct, the maintainers of the Cohesity PowerShell Modules project may take action, removing issues, comments, and PRs or blocking accounts as deemed appropriate.

If you are subject to or witness unacceptable behavior, or have any other concerns, please email us at [conduct@cohesity.com](mailto:conduct@cohesity.com).
