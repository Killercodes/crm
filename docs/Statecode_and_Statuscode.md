# Dynamics 365 CE Statecode & Statuscode per entity

| Entity                                                | Status (statecode)    | Status Reason (statuscode)        |
|-------------------------------------------------------|-----------------------|-----------------------------------|
| Account (account)                                     | 0 Active              | 1 Active                          |
|                                                       | 1 Inactive            | 2 Inactive                        |
| Activity (activitypointer)                            | 0 Open                | 1 Open                            |
|                                                       | 1 Completed           | 2 Completed                       |
|                                                       | 2 Canceled            | 3 Canceled                        |
|                                                       | 3 Scheduled           | 4 Scheduled                       |
| Appointment (appointment)                             | 0 Open                | 1 Free                            |
|                                                       |                       | 2 Tentative                       |
|                                                       | 1 Completed           | 3 Completed                       |
|                                                       | 2 Canceled            | 4 Canceled                        |
|                                                       | 3 Scheduled           | 5 Busy                            |
|                                                       |                       | 6 Out of Office                   |
| Article (kbarticle)                                   | 1 Draft               | 1 Draft                           |
|                                                       | 2 Unapproved          | 2 Unapproved                      |
|                                                       | 3 Published           | 3 Published                       |
| Campaign (campaign)                                   | 0 Active              | 0 Proposed                        |
|                                                       |                       | 1 Ready To Launch                 |
|                                                       |                       | 2 Launched                        |
|                                                       |                       | 3 Completed                       |
|                                                       |                       | 4 Canceled                        |
|                                                       |                       | 5 Suspended                       |
| Campaign Activity (campaignactivity)                  | 0 Open                | 0 In Progress                     |
|                                                       |                       | 1 Proposed                        |
|                                                       |                       | 4 Pending                         |
|                                                       |                       | 5 System Aborted                  |
|                                                       |                       | 6 Completed                       |
|                                                       | 1 Closed              | 2 Closed                          |
|                                                       | 2 Canceled            | 3 Canceled                        |
| Campaign Response (campaignresponse)                  | 0 Open                | 1 Open                            |
|                                                       | 1 Closed              | 2 Closed                          |
|                                                       | 2 Canceled            | 3 Canceled                        |
| Case (incident)                                       | 0 Active              | 1 In Progress                     |
|                                                       |                       | 2 On Hold                         |
|                                                       |                       | 3 Waiting for Details             |
|                                                       |                       | 4 Researching                     |
|                                                       | 1 Resolved            | 5 Problem Solved                  |
|                                                       | 2 Canceled            | 6 Canceled                        |
| Case Resolution (incidentresolution, notcustomizable) | 0 Open                | 1 Open                            |
|                                                       | 1 Completed           | 2 Closed                          |
|                                                       | 2 Canceled            | 3 Canceled                        |
| Contact (contact)                                     | 0 Active              | 1 Active                          |
|                                                       | 1 Inactive            | 2 Inactive                        |
| Contract (contract)                                   | 0 Draft               | 1 Draft                           |
|                                                       | 1 Invoiced            | 2 Invoiced                        |
|                                                       | 2 Active              | 3 Active                          |
|                                                       | 3 On Hold             | 4 On Hold                         |
|                                                       | 4 Canceled            | 5 Canceled                        |
|                                                       | 5 Expired             | 6 Expired                         |
| Contract Line (contractdetail)                        | 0 Existing            | 1 New                             |
|                                                       | 1 Renewed             | 2 Renewed                         |
|                                                       | 2 Canceled            | 3 Canceled                        |
|                                                       | 3 Expired             | 4 Expired                         |
| Currency (transactioncurrency)                        | 0 Active              | 0 Active                          |
|                                                       | 1 Inactive            | 1 Inactive                        |
| Discount (discounttype)                               | 0 Active              | 100001 Active                     |
|                                                       | 1 Inactive            | 100002 Inactive                   |
| E-mail (email)                                        | 0 Open                | 0 Draft                           |
|                                                       |                       | 8 Failed                          |
|                                                       | 1 Completed           | 2 Completed                       |
|                                                       |                       | 3 Sent                            |
|                                                       |                       | 4 Received                        |
|                                                       |                       | 6 Pending Send                    |
|                                                       |                       | 7 Sending                         |
|                                                       | 2 Canceled            | 5 Canceled                        |
| Fax (fax)                                             | 0 Open                | 0 Open                            |
|                                                       | 1 Completed           | 2 Completed                       |
|                                                       |                       | 3 Sent                            |
|                                                       |                       | 4 Received                        |
|                                                       | 2 Canceled            | 5 Canceled                        |
| Invoice (invoice)                                     | 0 Active              | 1 New                             |
|                                                       |                       | 2 Partially Shipped               |
|                                                       |                       | 4 Billed                          |
|                                                       |                       | 5 Booked (applies to services)    |
|                                                       |                       | 6 Installed (applies to services) |
|                                                       | 1 Closed (deprecated) | 3 Canceled (deprecated)           |
|                                                       |                       | 7 Paid in Full (deprecated        |
|                                                       | 2 Paid                | 100001 Complete                   |
|                                                       |                       | 100002 Partial                    |
|                                                       | 3 Canceled            | 100003 Canceled                   |
| Lead (lead)                                           | 0 Open                | 1 New                             |
|                                                       |                       | 2 Contacted                       |
|                                                       | 1 Qualified           | 3 Qualified                       |
|                                                       | 2 Disqualified        | 4 Lost                            |
|                                                       |                       | 5 Cannot Contact                  |
|                                                       |                       | 6 No Longer Interested            |
|                                                       |                       | 7 Canceled                        |
| Letter (letter)                                       | 0 Open                | 1 Open                            |
|                                                       |                       | 2 Draft                           |
|                                                       | 1 Completed           | 3 Received                        |
|                                                       |                       | 4 Sent                            |
|                                                       | 2 Canceled            | 5 Canceled                        |
| Marketing List (list)                                 | 0 Active              | 0 Active                          |
|                                                       | 1 Inactive            | 1 Inactive                        |
| Opportunity (opportunity)                             | 0 Open                | 1 In Progress                     |
|                                                       |                       | 2 On Hold                         |
|                                                       | 1 Won                 | 3 Won                             |
|                                                       | 2 Lost                | 4 Canceled                        |
|                                                       |                       | 5 Out-Sold                        |
| Order (salesorder)                                    | 0 Active              | 1 New                             |
|                                                       |                       | 2 Pending                         |
|                                                       | 1 Submitted           | 3 In Progress                     |
|                                                       | 2 Canceled            | 4 No Money                        |
|                                                       | 3 Fulfilled           | 100001 Complete                   |
|                                                       |                       | 100002 Partial                    |
|                                                       | 4 Invoiced            | 10003 Invoiced                    |
| Phone Call (phonecall)                                | 0 Open                | 1 Open                            |
|                                                       | 1 Completed           | 2 Made                            |
|                                                       |                       | 4 Received                        |
|                                                       | 2 Canceled            | 3 Canceled                        |
| Price List (pricelevel)                               | 0 Active              | 100001 Active                     |
|                                                       | 1 Inactive            | 10002 Inactive                    |
| Product (product)                                     | 0 Active              | 1 Active                          |
|                                                       | 1 Inactive            | 2 Inactive                        |
| Quote (quote)                                         | 0 Draft               | 1 In Progress                     |
|                                                       | 1 Active              | 2 In Progress                     |
|                                                       |                       | 3 Open                            |
|                                                       | 2 Won                 | 4 Won                             |
|                                                       |                       | 5 Out-Sold                        |
|                                                       | 3 Closed              | 5 Lost                            |
|                                                       |                       | 6 Canceled                        |
|                                                       |                       | 7 Revised                         |
| Service Activity (serviceappointment)                 | 0 Open                | 1 Requested                       |
|                                                       |                       | 2 Tentative                       |
|                                                       | 1 Closed              | 8 Completed                       |
|                                                       | 2 Canceled            | 9 Canceled                        |
|                                                       |                       | 10 No Show                        |
|                                                       | 3 Scheduled           | 3 Pending                         |
|                                                       |                       | 4 Reserved                        |
|                                                       |                       | 6 In Progress                     |
|                                                       |                       | 7 Arrived                         |
| Task (task)                                           | 0 Open                | 2 Not Started                     |
|                                                       |                       | 3 In Progress                     |
|                                                       |                       | 4 Waiting on someone else         |
|                                                       |                       | 7 Deferred                        |
|                                                       | 1 Completed           | 5 Completed                       |
|                                                       | 2 Canceled            | 6 Canceled                        |
