# Understanding Hierarchical Entity Relationships
 
Hierarchical entity relationships require that one of the records have a field to store a unique identifier that references another record. The record that stores the reference to another record is called the child record ( A record in a hierarchical relationship with a parent record where a reference to the parent record is stored in the record. One parent record can be related to many child records. Child records have lookup fields in the form to allow them to be related to a parent record. ) . The record referenced by the unique identifier in the child record is called the parent record ( A record that is in a hierarchical relationship with a child record, where a reference to the record is stored in the child record. One parent record can be related to many child records. ) .

A hierarchical relationship allows each child record ( A record in a hierarchical relationship with a parent record where a reference to the parent record is stored in the record. One parent record can be related to many child records. Child records have lookup fields in the form to allow them to be related to a parent record. ) to store a reference to one parent record ( A record that is in a hierarchical relationship with a child record, where a reference to the record is stored in the child record. One parent record can be related to many child records. ) . A parent record can be referenced by an unlimited number of child records. The parent record can display all the child records in an associated view ( The view of an entity that is displayed in the forms of other entities. The associated view is different from the views that are visible for the entity in its own area of the user interface. For example, in an account record, under Details, you can click Contacts to view and open a contact form. That is the Contacts associated view. There can be only one associated view of each entity. ) .

Issues related to Hierarchical relationships include:
- Defining Relationships
- Data Integrity
- Relationship Behavior
- Limitations for Hierarchical Relationships
- Mapping

## Defining Relationships

Relationships are defined between entities. The entity that will represent the child records is called the related entity ( An entity that is associated with a primary entity (record type) through a unique reference defined by using a lookup control on the related entity form. For example, an account has a unique reference to a primary contact. ) . A relationship attribute ( An attribute that exists in a related entity when a hierarchical relationship exists. When added to the form of the related entity, a lookup control is displayed to allow the record to be related to another record as defined in the relationship. ) , also known as a lookup attribute ( An attribute used to create a reference to a related record. Also known as a relationship attribute. ) , is created on the related entity to allow records to store a reference to a parent record. The entity that will represent the parent records is called the primary entity ( The entity that a related entity is associated to. Sometimes called a parent entity. ) in the relationship.

When you create or edit a relationship between entities in Microsoft Dynamics CRM you must start from one of the entities. Which entity is not important because only one relationship will be created and only one relationship needs to be edited. The terminology used depends on whether you start from the primary entity ( The entity that a related entity is associated to. Sometimes called a parent entity. ) or the related entity ( An entity that is associated with a primary entity (record type) through a unique reference defined by using a lookup control on the related entity form. For example, an account has a unique reference to a primary contact. ) .

- A **1:N Relationship** is a hierarchical relationship created or viewed from the primary entity. Any one record from the primary entity can be referenced by many records from the related entity.

- A **N:1 Relationship** is a hierarchical relationship created or viewed from the related entity. Many records from the related entity can reference any one record from the primary entity.

**Note:** It is important to remember that the same relationship can be viewed from either of the two entities that participate in the relationship.

 

## Data Integrity

A hierarchical relationship introduces the opportunity to define rules for data integrity. For example, an opportunity (_A potential revenue-generating event or sale to an account that needs to be tracked through a sales process to completion._) 
record has no meaning if it isn't associated with a customer record. Microsoft Dynamics CRM requires that an opportunity record be related to a customer record. However, a task activity ( An action to be performed, such as a task, or a communication item that is sent or received, for example, e-mail, phone calls, and appointments. The status of activities is tracked and the activity history is stored in the system, so users can view the open and closed activities. ) can be meaningful whether it is associated to another record or not. Relating a task activity to another record is optional.

When you create a relationship, you must choose whether to enforce rules for data integrity. If you make the relationship attribute on the related entity a required field by setting a requirement level ( A setting that determines whether users must enter data. For example, when the requirement level of a field is set to Business Required, users will be unable to save the record without entering data in that field. The field will also appear in the Quick Create form. ) of Business Required, you can guarantee that each of the related entity records created through the Microsoft Dynamics CRM application will be related to a record of the parent entity.

Note: Field level constraints only apply to the Microsoft Dynamics CRM application. Records created programmatically through the Microsoft Dynamics CRM Web services are not required to respect field level constraints.

 

## Relationship Behavior

Once you create a hierarchical relationship you can control how the relationship behaves to support both data integrity and business rules for your organization. The relationship can control how actions performed on a parent record will cascade down to child records.

You can configure the relationship behavior for the following actions performed on the record of the primary entity:

- **Assign** ( The related records will be assigned to the same user. )
- **Share** ( The related entity records will also be shared with the same user or team. )
- **Unshare** ( The related entity records will no longer be shared with the same user or team. )
- **Reparent** ( If the owner of the primary entity record changes because the primary entity record was reparented, the owner of any related records will be set to the same owner as the primary entity record. )
- **Delete** ( The related records can be deleted, unlinked from the primary entity record, or the delete action can be canceled. )
- **Merge** ( The related records associated with the subordinate record will be reparented to the master record. )

You can choose from three pre-defined and commonly used types of behavior, or you can choose to configure the appropriate cascading action for each action performed on the record of the primary entity.

The three predefined types of behavior are:

- **Parental**
In a Parental type of behavior, all actions cascade down to the related records. For example, if a parent record is deleted, all child records will also be deleted. If a parent record is reassigned, all the child records are reassigned to the same user.

- **Referential**
In a Referential type of behavior, none of the actions will cascade down to child records. For example, when a parent record is deleted, the data linking that record in any child records is removed.

- **Referential, Restrict Delete**
The Referential, Restrict Delete type of behavior is the same as Referential except that the deletion action is not allowed if there are any related records.

You can also choose to define specific cascading behavior for each of the actions by choosing the Configurable Cascading type of behavior. For most actions, your choices are:

- **Cascade All**
This is the behavior of the Parental type of behavior. All actions will cascade to all child records, including inactive records.

- **Cascade Active**
Actions will only cascade down to active child records.

- **Cascade User-Owned**
Actions will only cascade down to child records assigned to the same user as the owner of the parent record.

- **Cascade None**
This is the behavior of the Referential type of behavior. No actions will cascade.

Data integrity must be preserved when data in records changes or when the status of records change. For example, deleting a parent record breaks the data integrity of any child records if the relationship is required. There are three ways to address this:

- Use the Referential, Restrict Delete type of behavior to prevent the deletion of any records that have dependent child records.
- Use the Parental type of behavior to delete any dependent child records for any parent records that are deleted.
- Use the Configurable Cascading type of behavior and set the Delete action to either Cascade All or Restrict.

If the relationship is not required, it is sufficient to remove the data that establishes the link to the deleted parent record.

In addition to data integrity, your business may have rules that should be applied when data in records changes or when the status of records changes. For example, some organizations may want to reassign all child records when the a parent record is reassigned. The Relationship behavior can cascade this action so it does not need to be done manually.

 
## Limitations for Hierarchical Relationships

- **Parental Relationships**
Each entity can participate in only one parental ( A relationship between entities in which any action taken on a record of the parent entity is also taken on any child entity records that are related to the parent entity record. For example, if you delete a record in the parent entity, the related child entity records are also deleted; or if you share a parent entity record, the related records from the child entity are also shared. ) relationship. Most Microsoft Dynamics CRM  system entities ( Entities that are included in Microsoft Dynamics CRM by default, such as Account. )   already participate in a parental relationship and this relationship cannot be changed.

- **Number of Relationships**
Enities can have referential relationships with any entity, including system entities. You can create multiple relationships between two entities. Entities can even have referential relationships with themselves - allowing linked records of the same type. However, a record cannot be linked to itself.

- **Relationships with Customer Records**
Customers in Microsoft Dynamics CRM may be Accounts or Contacts. These two entities together represent a composite Customer ( The account or contact with which a business unit conducts a business transaction. ) entity. Some Microsoft Dynamics CRM system entities, such as Opportunity and Case must be related to a Customer. However, you cannot create this type of relationship with custom entities.

 

## Mapping
New child records can be created by users in the associated view ( The view of an entity that is displayed in the forms of other entities. The associated view is different from the views that are visible for the entity in its own area of the user interface. For example, in an account record, under Details, you can click Contacts to view and open a contact form. That is the Contacts associated view. There can be only one associated view of each entity. ) if they click the New button. When this happens, data from the parent record is copied into the form for the new child record. By default, a reference to the parent record is always copied to the relationship lookup field in the child record. You can choose whether data from other fields should be copied at the same time.
