#Bundledocs Api Wrapper Common Functions

##Wrapper
* To access the api wrapper
	* __`protected BundledocsApi _bundledocsApi = BundledocsApi.New(App.Default.authorization);`__

##Users
* Load User
	* The App.settings file must have a user's authorization key stored in order to access their account
	* __`UserBean user = _bundledocsApi.Users.Me();`__

##Bundles
* Create  
	* To create a new bundle
	* __`BriefBean briefBean = _bundledocsApi.Bundles.Create(PartitionKey, RowKey);`__
* Delete  
	* To delete a bundle
 	* __`BriefBean deletedBrief = _bundledocsApi.Bundles.Delete(PartitionKey, RowKey);`__
* Load  
	* To load a bundle
	* __`BriefBean loadedBrief = _bundledocsApi.Bundles.Get(PartitionKey, RowKey);`__  
* Generate    
	* To generate a bundle
	* __`OAuthApiMessage generateMessage = _bundledocsApi.Bundles.Generate(loadedBriefPartitionKey, loadedBriefRowKey, BriefBean);`__
* Download  
	* To open a download stream for a bundle  
		* __`Stream myStream = _bundledocsApi.Bundles.Download(PartitionKey, RowKey);`__  
	* To save the bundle to the computer  
		* __`byte[] myFile = myStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`__  
	* To wait for the bundle to complete  
		* __`bool generateComplete = _bundledocsApi.Events.WaitForGenerateToComplete(RowKey);`__  
* Receipts  
	* To get a list of bundle receipts  
		* __`List<BriefReceipt> briefReceipts = _bundledocsApi.Bundles.Receipts(PartitionKey, RowKey);`__  
	* To open a download stream for a receipt  
		* __`Stream briefReceiptStream = _bundledocsApi.Receipts.Download(ReceiptPartitionKey, ReceiptRowKey);`__  
	* To save the receipt to the computer  
		* __`byte[] myFile = briefReceiptStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`__  

##Sections
To access a section the containing bundle must first be loaded  
* Create  
	* To create a new section
	* __`BriefDocument newSection = _bundledocsApi.Sections.Create(loadedBriefPartitionKey, loadedBriefRowKey, sectionName);`__
* Rename  
	* To rename a section
	* __`BriefDocument renamedSection = _bundledocsApi.Sections.Rename(sectionPartitionKey, sectionRowKey, newName);`__
* Delete  
	* To delete a section
	* __`BriefDocument deletedSection = _bundledocsApi.Sections.Delete(sectionPartitionKey, sectionRowKey);`__
* Load
	* To load the sections of a bundle
		* __`IEnumerable<BriefDocument> sections = _bundledocsApi.Bundles.Tree(BriefPartitionKey, BriefRowKey).Where(k => k.Type == "HEADER")`__
	* To load a section of a bundle
		* __`BriefDocument section = _bundledocsApi.Bundles.Tree(BriefPartitionKey, BriefRowKey).Where(k => k.Type == "HEADER" && k.Description == "sectionName").FirstOrDefault();`__

##Documents
* Create  
	* To add a document to a section  
		* __`bool isSuccess = _bundledocsApi.Documents.Create(loadedSection, FileLocation);`__  
	* To wait for the upload to complete  
		* __`bool completed = _bundledocsApi.Events.WaitForUploadToComplete(uploadLocation.ForeignKey);`__  
* Download  
	* To open a download stream for a document  
		* __`Stream myStream = _bundledocsApi.Documents.Download(documentToDownloadPartitionKey, documentToDownloadRowKey);`__  
	* To save the document to the computer  
		* __`byte[] myFile = myStream.ReadToEnd();`  
		`string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
		`File.WriteAllBytes(newFilePath, myFile);`__  
* Rename  
	* To rename a document  
	* __`BriefDocument renamedDocument = _bundledocsApi.Documents.Rename(PartitionKey, RowKey, newName);`__  
* Delete  
	* To delete a document  
	* __`BriefDocument deletedDocument = _bundledocsApi.Documents.Delete(documentToDeletePartitionKey, documentToDeleteRowKey);`__  
