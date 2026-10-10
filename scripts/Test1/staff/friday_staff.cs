#include "lib/_assign.cs"
#include "lib/_jobs.cs"
#include "lib/_scorers.cs"

DoStaffAssignments(_222-r1, 2027-07-23,
                   [Judges(), Scramblers(4, _222), Runners(3, _222), Delegate()],
                   StaffScorers(_222, 2027-07-23))
DoStaffAssignments(_444-r1, 2027-07-23,
                   [Judges(), Scramblers(3, _444), Runners(4, _444), Delegate()],
                   StaffScorers(_444, 2027-07-23))
DoStaffAssignments(_sq1-r1, 2027-07-23,
                   [Judges(), Scramblers(4, _sq1), Runners(3, _sq1), Delegate()],
                   StaffScorers(_sq1, 2027-07-23))
DoStaffAssignments(_666-r1, 2027-07-23,
                   [Judges(), Scramblers(4, _666), Runners(4, _666), Delegate()],
                   StaffScorers(_666, 2027-07-23))