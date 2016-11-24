#Bundledocs Api Wrapper

##Common Functions

###Users
* Login  
* Update Options

###Bundles
* Create  
  * To create a new bundle
    * `BriefBean briefBean = _bundledocsApi.Bundles.Create(expectedCode, expectedTitle);`
* Delete  
  * To delete a bundle
    * `BriefBean deletedBrief = _bundledocsApi.Bundles.Delete(PartitionKey, RowKey);`
* Load
  * To load a bundle
    * `BriefBean loadedBrief = _bundledocsApi.Bundles.Get(PartitionKey, RowKey);`  
* Generate 
  * To generate a bundle it must first be loaded
  * Then the generate function can be called
    * `OAuthApiMessage generateMessage = _bundledocsApi.Bundles.Generate(loadedBrief.PartitionKey, loadedBrief.RowKey, loadedBrief);`
* Download  
  * To open a download stream for a bundle
    * `Stream myStream = _bundledocsApi.Bundles.Download(PartitionKey, RowKey);`
  * To save the bundle to the computer
    * `byte[] myFile = myStream.ReadToEnd();`  
     `string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
     `File.WriteAllBytes(newFilePath, myFile);`
* Receipts  
  * To get a list of bundle receipts
    * `List<BriefReceipt> briefReceipts = _bundledocsApi.Bundles.Receipts(PartitionKey, RowKey);`
	* To open a download stream for the receipts
		* `Stream briefReceiptStream = _bundledocsApi.Receipts.Download(ReceiptToDownload.PartitionKey, ReceiptToDownload.RowKey);`
	* To save the receipts to the computer
		* `byte[] myFile = briefReceiptStream.ReadToEnd();`
      `string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`
      `File.WriteAllBytes(newFilePath, myFile);`
* Share
* Migrate  
* Copy

###Sections
* To access a section the containing bundle must first be loaded
* Create  
  * To create a new section
  	* `BriefDocument newSection = _bundledocsApi.Sections.Create(loadedBrief.PartitionKey, loadedBrief.RowKey, sectionName);`
* Rename  
  * To rename a section
  	* `BriefDocument renamedSection = _bundledocsApi.Sections.Rename(sectionToRename.PartitionKey, sectionToRename.RowKey, newName);`
* Delete  
  * To delete a section
  	* `BriefDocument deletedSection = _bundledocsApi.Sections.Delete(section.PartitionKey, section.RowKey);`
* Copy  
* Get
* Toggle included  
* Toggle expanded

###Documents
* Create
	*	To add a document to a section
		* `bool isSuccess = _bundledocsApi.Documents.Create(loadedSection, App.Default.UploadFileLocation);`
* Download
	* To open a download stream for a document
		* `Stream myStream = _bundledocsApi.Documents.Download(documentToDownload.PartitionKey, documentToDownload.RowKey);`
	* To save the document to the computer
		* `byte[] myFile = myStream.ReadToEnd();`  
      `string newFilePath = $@"{App.Default.TempFolder}{Guid.NewGuid().ToString("n")}.pdf";`  
      `File.WriteAllBytes(newFilePath, myFile);`
* Rename 
	* To rename a section
		* `BriefDocument renamedDocument = _bundledocsApi.Documents.Rename(PartitionKey, RowKey, newName);`
* Delete 
	* To deleta a document
		* `BriefDocument deletedDocument = _bundledocsApi.Documents.Delete(documentToDelete.PartitionKey, documentToDelete.RowKey);`
* Merge  
* Copy  
* Toggle included

###Groups
* Create  
* Get  
* Delete  
* Add members  
* Delete members

###Authentification
* Make token
