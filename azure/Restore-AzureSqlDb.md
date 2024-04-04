# Accidentally deleted Azure SQL Server. How can I recover it and its databases?

- Article
- 04/10/2019

Original Source: [Accidentally deleted Azure SQL Server. How can I recover it and its databases? | Microsoft Learn](https://learn.microsoft.com/en-us/archive/msdn-technet-forums/332db716-3860-44e2-a0f7-9c0828fe81e8)

#### Question

Wednesday, April 10, 2019 4:12 PM

I thought I was deleting one of the databases but accidentally deleted the SQL server with all of the databases. Please tell me there's a way to recover from this.



#### All replies (5)

Wednesday, April 10, 2019 4:49 PM

If we delete SQL server itself , all the associated  items will gone permanently. So unfortunate that you cannot recover it. But Yes, you need to open a support ticket to Microsoft  - upper right-hand corner in the Azure Portal (Assumed retention period for your Service Tier still in place )

![img](https://learn.microsoft.com/en-us/archive/msdn-technet-forums/332db716-3860-44e2-a0f7-9c0828fe81e8)![img](https://learn.microsoft.com/en-us/archive/msdn-technet-forums/azure/ssdsgetstarted/images/1426568.png)

Please click "Mark as Answer" if it solved your issue and/or "Vote as helpful" if it helped. This can be beneficial to other community members reading this thread.

------

Wednesday, April 10, 2019 10:38 PM

Hi Suman,

Recreate the SQL server instance with the same name and same region but, during the database creation process, select restore from backup. You should see a series of backups that you can select from. These are the automatic backups your Azure SQL Server instance has been managing as part of the service you pay for. These backups are available from 7 to 35 days. You can read more here: [Automated Backups](https://learn.microsoft.com/en-us/azure/sql-database/sql-database-automated-backups) 

If you do not happen to see them, then please engage Azure Support. If you do not have an [Azure Support Plan](https://azure.microsoft.com/en-us/support/plans/) then please send me your Azure Subscription ID to AzCommunity at Microsoft.com and I will return instructions to have a support request created.

Regards,

Mike

------

Thursday, April 11, 2019 12:50 PM

Hi Mike,

Thanks a lot for your replay and provided your thoughts on it..

But I go through below article . as per this article

If we delete the Azure SQL server that hosts SQL databases, all elastic pools and databases that belong to the server are also deleted and cannot be recovered. You cannot restore a deleted server. But if you configured long-term retention, the backups for the databases with LTR will not be deleted and these databases can be restored.

[/en-us/azure/sql-database/sql-database-automated-backups](https://learn.microsoft.com/en-us/azure/sql-database/sql-database-automated-backups)

Please cross validate this document under "How long are backups kept" topic and let us know your thoughts on it. Thanks

Please click "Mark as Answer" if it solved your issue and/or "Vote as helpful" if it helped. This can be beneficial to other community members reading this thread.

------

Thursday, April 11, 2019 4:39 PM

That is correct, you need to configure Long Term Backups to be able to select from the available backups that are saved across a given subscription.

During the Create SQL Database process, on the Basics page, you leave the Database Name value empty and click to the next page where you choose to create the database from an available backup file:

![img](C:\Users\Nils.Telleria\OneDrive - iQmetrix Software Development Corp\Desktop\1427103.png)

------

Thursday, April 11, 2019 4:44 PM

> That is correct, you need to configure Long Term Backups to be able to select from the available backups that are saved across a given subscription.
>
> --> Yes exactly.. Thanks Mike for your replay

Please click "Mark as Answer" if it solved your issue and/or "Vote as helpful" if it helped. This can be beneficial to other community members reading this thread.

