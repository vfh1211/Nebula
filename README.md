# Nebula
## AI-Driven Consulting as a Service

### Concept

<em>“Nebula is an AI/ML driven Consulting as a Service software solution venture given birth by joint efforts between IT D&A and EPG SIE engineers.  Focused on replacing consultants by leveraging software services-oriented architectures coded in C++, Java and/or C#, Big Data, BI, AI/ML, DPG, Ethernet & Edge Group’s Global Intel’s Network Distributed Grid, it’s capable of replacing biased and not-data-driven decisions @ Intel, due to years of relying exclusively on Legacy Consultants from well-known companies.  Our solution provides data-driven decisions based on optimal analysis of low-level metrics of a SW/HW product created to fulfil a business need. We’re looking for two or three folks for each of the technologies specified above; two or three hours a week per human resource will suffice for 6 months. Interested? Reach out to either Gur or myself.

Do you want to learn & apply the most innovative “on the edge” network distributed data structures such as Merkle Trees, Blockchains or Hash Graphs, are you passionate about Full & Partial Byzantine Consensus Algorithms, Gossip Protocols, Distributed Transaction Logs and how each of these data structures achieves a quorum in order to execute a transaction (i.e., add a new validated/legit block to the data structure in all the copies in all the distributed nodes).

You have a background in crypto/blockchain/consensus mechanisms? Are you passionate about improving connectivity solutions? 
Our start-up venture involves networking on the edge of Web 3.0 & establishing 100% trust in a distributed environment. 
Please do DM me/Gur if you are interested in joining. I'll be happy to share more details and have a discussion. Thanks”<em>



## Setting up GitHub Environment

### Pre-requisites

1. Complete the “GitHub DOs & DONT's” training in My Learning (ID 0020021180).
2. Create a new account in GitHub
3. Use your Intel email.
4. Use your idsid as username.
5. Use a strong password.
6. Set the email as Public.
7. Visit  https://github.com/settings/emails and ensure your "@intel.com" email is set as “Primary email address”. If necessary, add your email, then set to primary.
8. Visit  https://github.com/settings/profile and select your email in the “Public email” section.
9. Verify your email using the link sent after the account is created.
10. Request access to 1Source Github User role in AGS.
11. Accept the invitations to intel-innersource and intel-sandbox organizations.
12. Request access to DCA ETL repository
13. If you require Admin access request on AGS the following entitlement: ATS SCM ADMIN
14. If you require Maintain (developer) access request on AGS the following entitlement: ATS SCM MAINTAIN
15. Install Git tools and GIT LFS (if it has not being installed yet).
16. GitLFS can be found here:  https://git-lfs.github.com/
17. Generate the necessary SSH keys by using the following commands on how to Generate SSH keys. If you already have an existing SSH keys, you can reuse them, there is no need to generate new ones.

Verify that all the required steps to get started with 1Source in the onboarding page are completed. When it shows all green, you’re all set.

**Note:** It is not required to request the 1Source Github Restricted User and 1Source Github Collab User AGS entitlements.

### Configure GitHub on Windows

Follow these instructions to configure and setup GitHub on Windows:
18. Download "devtool" from here:  https://gfx-assets.intel.com/artifactory/gfx-build-assets/build-tools/devtool-go/latest/artifacts/win64/dt.exe
19. In the Windows Command Prompt run the following command:
```java 
.\Downloads\dt.exe install 
```
20. Running Git Bash as Administrator, run the following command:
```java
dt install --git-aliases
```
21. In a new terminal using Git Bash, run the following commands:
```java
dt setup
```
22. When prompted, type "Y" to allow devtool to manage the GitHub proxy settings.
23. When prompted, type your Intel email address.
24. When prompted, type your full name.
25. When prompted to choose to store your GitHub token, use the up or down arrow key and select "keyring".
26. The process will ask you to login into GitHub using a web browser on the following URL: https://github.com
27. Once you have login into GitHub, return to the Git Bash terminal and press <Enter> to continue.
28. The process will prompt you a "one-time security code". Using a web browser, go to the following URL:  https://github.com/login/device and type the code there and click on "Continue".
29. Click on "authorized intel-innersource" and type your GitHub password when it is requested.
30. When the authorization step is completed the setup process will continue on the Git Bash terminal.
31. Once the setup process is completed, you can close all the terminals and web browsers.
32. Add your SSH key into GitHub following the instructions on Adding a new SSH key to your GitHub account
33. Authorized the SSH key for SSO following the instructions on Authorizing an SSH key for use with SAML SSO
34. Add the following section to the file ~/.ssh/config replacing "_github_ssh_private_key_". by the name of your private keyfile. If the file ~/.ssh/config does not exists, create it.
35. Setup SSH proxy

```bash
host github.com
    ProxyCommand connect -a none -S proxy-dmz.intel.com:1080 %h %p
    IdentityFile ~/.ssh/_github_ssh_private_key_
````

36. Test the SSH setup running the following command:
* ssh -T git@github.com
* If you are prompted with a fingerprint warning, validate if it matches GitHub's public RSA fingerprints, if it does type "yes" to the question "Are you sure you want to continue connecting".
* You should get a message with your username. If you receive a "permission denied" message, visit Error: Permission denied (publickey)
* GitHub successful SSH test
* Hi username! You've successfully authenticated, but GitHub does not
* provide shell access.

Pull **Nebula** Project Folders to Local Repository

Follow these instructions to pull the DCA project files to your local repository:

37. Validate that you have access to DCA ETL GitHub repository intel-innersource/applications.analytics.data-collector-analyzer.etl
38. Create or navigate to the folder where you want the DCA project code to exists
39. Run the following command:
40. git clone git@github.com:intel-innersource/applications.analytics.data-collector-analyzer.etl.git
41. If the previous command did not work, run the following command:
42. git clone https://github.com/intel-innersource/applications.analytics.data-collector-analyzer.etl.git
Follow these instructions to test that you are able to commit changes from your local repository:
43. Run the following commands (replace >>idsid<< by your own idsid):
```bash
44. git checkout master
45. git pull
46. git branch >>idsid<<_test_branch
47. git checkout >>idsid<<_test_branch
48. Create a dummy file with any content
49. git status
50. git add .
51. git commit -m "Testing file"
52. git push origin >>idsid<<_test_branch
53. Please proceed to destroy the test branch, Source Control MUST be kept clean
```
53. In case of an issue, contact the Project Nebula Solution Architect and Product Manager: **Flores, Vinicio**: vinicio.flores@intel.com or **Sannikov, Gur**: gur.sannikov@intel.com

### Lifecycle Guidelines

Three branches are used: _dev-main, qat-main, prod-main_

* All changes are done in a new "feature branch" the developer creates with the following naming convention: ``` [<Teams Kanban Item ID>]-[<Teams Kanban Work Item Name>]-[developer_name] ```
* No merge occurs without code & architectural review
* No push occurs without code & architectural

### Steps to path to production

1. Create feature branch as highlighted above **from prod-main branch**
2. Perform your changes there in your "feature branch"
3. Git checkout to dev-main after you're 100% to have working code
4. Send a GitHub merge/code review request for discussion & approval
5. Code will run in QAT for a specified timeframe (depending on the nature of the change and commitment during review)
6. Once code proofs being stable in QAT environment, proceed to hand-out to the **Designated Release Owner** who'll perform the actual merge to _prod-main_ branch and deploy to Production HW.


### Conventions

* Camel Case for public attributes
* We don't use the deprecated "MSFT-promoted Hungarian notation" for attributes/variables, in fact it's no longer promoted due to its lack of self-readibility AND **CODE MUST BE SELF-READABLE**
* Use of underscore and lowercase names for private attributes &
* Use of #region and #endregion to separate public, protected and private code inside each class
* Meaningful comments: DON'T describe what the code is doing already from a technical perspective, explain the purpose of the piece of code

### Base Task List

- [X] Get first customer on-board (**XCC - Custom Computing Group**)
- [X] Create Teams Group - Please join here: [Nebula]: https://teams.microsoft.com/l/team/19%3aW_vM_6CgKyZvFpfIDpaHZwxifcX0_EpXVWs4H7UMeAc1%40thread.tacv2/conversations?groupId=57b661b3-40f1-49a0-baf2-c3e93f4def8b&tenantId=46c98d88-e344-4ed4-8496-4ed7712e255d
- [ ] Expand core team - **<em>WIP</em>**
- [ ] Write the base interfaces 
- [ ] Write the base virtual/abstract classes
- [ ] Write the fist concrete class that implements both behaviour (classes) & attributes (class properties) to be able to bootstrap the **Analysis Agent**
- [ ] Write the **Analysis Agent** bootstrap (main function) as a multithreaded _Chain of Command_ Design Pattern which wakes-up 24/7 the concrete implementation of the **I/O monitoring services**


### Code Katas

<b>It's a given OKR from every Nebula developer to rely on reusable data structures and classes such as Interfaces, Generics, Abstract & Virtual classes to avoid reinventing the wheel. This allows the overall Service Oriented Architecture solution to add/edit/remove functionalities, modules and features easily to avoid refactoring to the minimum. This helps to incorporate technology (or deprecate when needed) with very little effort.</b>

##### Base Interfaces
```c#
* IConfigurable
* IService
* INotifiable
* ICloudable
* IConsultingStepExecutable
* IEngineIOReadable
* IEngineIOSerializable
```
##### Base Abstract & Virtual Classes
```c#
* AbstractService
* AbstractMessage
* AbstractDirectory
* AbstractBusinessProcess
* AbstractIOMetric
* AbstractIOOutput
```

##### Bootstrap SOA Main Entry Point 
* Bootstrap class in the project of the same name

