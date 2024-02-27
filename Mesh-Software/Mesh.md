# Online Stores - 
For the online store, which serves as the primary repository for published features and needs to support real-time access and updates, a database management system (DBMS) is typically used. Here are some commonly used types of databases for online stores:
Relational Database Management System (RDBMS): Examples: MySQL, PostgreSQL.

## Requirements:
* Storage of Features: The online store must securely store all published features.
* Accessibility: Users should be able to access features stored in the online store at any time.
* Search Functionality: Implement search functionality to allow users to easily find specific features.
* Real-time Updates: Ensure that any changes made to features are immediately reflected in the online store.
* Scalability: The online store should be scalable to accommodate a growing number of features and user requests.

## User Acceptance Testing (UAT) Specifications:
1. Feature Storage:
  * Test Case: Publish a feature using the library/GUI.
  * Expected : The feature is successfully stored in the online store database.

2. Accessibility:
  * Test Case: Attempt to access a feature from the online store.
  * Expected : The feature is accessible and can be retrieved without any issues.

3. Search Functionality:
  * Test Case: Perform a search for a feature by name or keyword.
  * Expected : The search returns relevant results matching the search criteria.

4. Real-time Updates:
  * Test Case: Modify an existing feature and verify its status in the online store.
  * Expected : The changes to the feature are immediately reflected in the online store without delay.

5. Scalability:
  * Test Case: Simulate a large number of concurrent access requests to the online store.
  * Expected : The online store handles the increased load efficiently without performance degradation.


# Offline stores (for Model Training Data) : 
For the offline store, which is used for storing training data used in batch processing for model training, you have several options depending on the scale of data and specific requirements: Distributed File System , Google Cloud storage . We need chose as per certain criteria.

## Requirements:
* Storage of Training Data: The offline store must store training data used for model training.
* Isolation from Online Store: Ensure that the offline store is separate from the online store to prevent interference with live data.
* Batch Processing Support: Provide support for batch processing of training data to train machine learning models.
* Compatibility with Training Environments: Ensure compatibility with common training environments such as Jupyter Notebook.
* Data Integrity: Maintain data integrity and consistency within the offline store.

## User Acceptance Testing (UAT) Specifications:
1. Training Data Storage:
  * Test Case: Upload training data to the offline store.
  * Expected Outcome: The training data is successfully stored in the offline store database.

2. Isolation from Online Store:
  * Test Case: Verify that modifications to training data in the offline store do not affect live features in the online store.
  * Expected : Changes to training data do not impact features stored in the online store.

3. Batch Processing Support:
  * Test Case: Initiate a batch processing job using training data from the offline store.
  * Expected : The batch processing job completes successfully, utilizing the training data for model training.

4. Compatibility with Training Environments:
  * Test Case: Access training data from the offline store within a Jupyter Notebook environment.
  * Expected : Training data is accessible and usable within the Jupyter Notebook for model training purposes.

5. Data Integrity:
  * Test Case: Verify the integrity of training data stored in the offline store.
  * Expected : Training data remains consistent and accurate, maintaining data integrity over time.
