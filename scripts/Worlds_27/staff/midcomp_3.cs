# Run after _555-r2, _pyram-r2 is entered

#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_pyram-r3, 2027-07-23,
                   [Judges(), Scramblers(5, _pyram), Runners(3, _pyram), Delegate()],
                   StaffScorers(_pyram, 2027-07-23))
DoStaffAssignments(_555-r3, 2027-07-23,
                   [Judges(), Scramblers(4, _555), Runners(4, _555), Delegate()],
                   StaffScorers(_555, 2027-07-23))