#Bundledocs Api Wrapper Common Functions

##Users
* Load User
	* `UserBean user = _bundledocsApi.Users.Me();`

##Bundles
* Create  
	* To create a new bundle
	* `BriefBean briefBean = _bundledocsApi.Bundles.Create(PartitionKey, RowKey);`
* Delete  
	* To delete a bundle
 	* `BriefBean deletedBrief = _bundledocsApi.Bundles.Delete(PartitionKey, RowKey);`
* Load  
	* To load a bundle
	* `BriefBean loadedBrief = _bundledocsApi.Bundles.Get(PartitionKey, RowKey);`  
* Generate    
	* To generate a bundle
	* `OAuthApiMessage generateMessage = _bundledocsApi.Bundles.Generate(loadedBriefPartitionKey, loadedBriefRowKey, BriefBean);`
* Download  
	* To open a download stream for a bundle  
		* `Stream myStream = _bundledocsApi.Bundles.Download(PartitionKey, RowKey);`  
	* To save the bundle to the computer  
		* `byte[] myFile = myStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`  
	* To wait for the bundle to complete  
		* `bool generateComplete = _bundledocsApi.Events.WaitForGenerateToComplete(RowKey);`  
* Receipts  
	* To get a list of bundle receipts  
		* `List<BriefReceipt> briefReceipts = _bundledocsApi.Bundles.Receipts(PartitionKey, RowKey);`  
	* To open a download stream for a receipt  
		* `Stream briefReceiptStream = _bundledocsApi.Receipts.Download(ReceiptPartitionKey, ReceiptRowKey);`  
	* To save the receipt to the computer  
		* `byte[] myFile = briefReceiptStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`  

##Sections
To access a section the containing bundle must first be loaded  
* Create  
	* To create a new section
	* `BriefDocument newSection = _bundledocsApi.Sections.Create(loadedBriefPartitionKey, loadedBriefRowKey, sectionName);`
* Rename  
	* To rename a section
	* `BriefDocument renamedSection = _bundledocsApi.Sections.Rename(sectionPartitionKey, sectionRowKey, newName);`
* Delete  
	* To delete a section
	* `BriefDocument deletedSection = _bundledocsApi.Sections.Delete(sectionPartitionKey, sectionRowKey);`
* Load
	* To load the sections of a bundle
		* `IEnumerable<BriefDocument> sections = _bundledocsApi.Bundles.Tree(BriefPartitionKey, BriefRowKey).Where(k => k.Type == "HEADER")`
	* To load a section of a bundle
		* `BriefDocument section = _bundledocsApi.Bundles.Tree(BriefPartitionKey, BriefRowKey).Where(k => k.Type == "HEADER" && k.Description == "sectionName").FirstOrDefault();`

##Documents
* Create  
	* To add a document to a section  
		* `bool isSuccess = _bundledocsApi.Documents.Create(loadedSection, FileLocation);`  
	* To wait for the upload to complete  
		* `bool completed = _bundledocsApi.Events.WaitForUploadToComplete(uploadLocation.ForeignKey);`  
* Download  
	* To open a download stream for a document  
		* `Stream myStream = _bundledocsApi.Documents.Download(documentToDownloadPartitionKey, documentToDownloadRowKey);`  
	* To save the document to the computer  
		* `byte[] myFile = myStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`  
* Rename  
	* To rename a document  
	* `BriefDocument renamedDocument = _bundledocsApi.Documents.Rename(PartitionKey, RowKey, newName);`  
* Delete  
	* To delete a document  
	* `BriefDocument deletedDocument = _bundledocsApi.Documents.Delete(documentToDeletePartitionKey, documentToDeleteRowKey);`  
