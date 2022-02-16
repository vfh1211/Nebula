# Nebula
## AI-Driven Consulting as a Service

### Concept

<em>“Nebula is an AI/ML driven Consulting as a Service software solution venture given birth by joint efforts between IT D&A and EPG SIE engineers.  Focused on replacing consultants by leveraging software services-oriented architectures coded in C++, Java and/or C#, Big Data, BI, AI/ML, DPG, Ethernet & Edge Group’s Global Intel’s Network Distributed Grid, it’s capable of replacing biased and not-data-driven decisions @ Intel, due to years of relying exclusively on Legacy Consultants from well-known companies.  Our solution provides data-driven decisions based on optimal analysis of low-level metrics of a SW/HW product created to fulfil a business need. We’re looking for two or three folks for each of the technologies specified above; two or three hours a week per human resource will suffice for 6 months. Interested? Reach out to either Gur or myself.

Do you want to learn & apply the most innovative “on the edge” network distributed data structures such as Merkle Trees, Blockchains or Hash Graphs, are you passionate about Full & Partial Byzantine Consensus Algorithms, Gossip Protocols, Distributed Transaction Logs and how each of these data structures achieves a quorum in order to execute a transaction (i.e., add a new validated/legit block to the data structure in all the copies in all the distributed nodes).

You have a background in crypto/blockchain/consensus mechanisms? Are you passionate about improving connectivity solutions? 
Our start-up venture involves networking on the edge of Web 3.0 & establishing 100% trust in a distributed environment. 
Please do DM me/Gur if you are interested in joining. I'll be happy to share more details and have a discussion. Thanks”<em>

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

* CamelCase for public attributes
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

