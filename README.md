This is a microservice for IW Printing

Job 1:

POST
url: https://localhost:5001/api/print
body:
["extra-margin",
"envelopes 520.00 abs",
"letterhead 1983.37 exempt"]

Job 2:

POST
url: https://localhost:5001/api/print
body:
["t-shirts 294.04"]


Job 3:

POST
url: https://localhost:5001/api/print
body:
["extra-margin",
"frisbees 19385.38 exempt",
"yo-yos 1829 exempt"]