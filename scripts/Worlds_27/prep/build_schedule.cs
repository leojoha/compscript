#include "../lib/_constants.cs"

# Add multi cube submission e.g.: CreateMiscActivity("Cube Submission for 3x3x3 Multi-Blind", "other-multi", SIDE, 2027-07-22T08:30, 2027-07-22T09:30)

ClearSchedule()
ClearStages()
DeleteRooms(["Hall A", "Hall BC", "Hall DE", "Side Room"])

CreateRoom("Hall A", "#4040a8")
CreateRoom("Hall BC", "#bd2b2b")
CreateRoom("Hall DE", "#8b4eba")
CreateRoom("Side Room", "#3a3a3a")

CreateStage("Blue Stage", "Hall A", "#4a4aff")
CreateStage("Yellow Stage", "Hall A", "#c3c636")

CreateStage("Red Stage", "Hall BC", "#bd2b2b")
CreateStage("Green Stage", "Hall BC", "#46ab3b")
CreateStage("Orange Stage", "Hall BC", "#c08431")
CreateStage("White Stage", "Hall BC", "#ffffff")

CreateStage("Purple Stage", "Hall DE", "#6d2792")
CreateStage("Brown Stage", "Hall DE", "#503018")
CreateStage("Pink Stage", "Hall DE", "#dd58b3")
CreateStage("Black Stage", "Hall DE", "#000000")

CreateStage("Side Room", "Side Room", "#29b9ab")

# Thursday

Map(HallA(), CreateGroups(_555bf-r1, 1, 2027-07-22T09:00, 2027-07-22T09:45))

Map(HallA(), CreateGroups(_333oh-r1, 3, 2027-07-22T09:45, 2027-07-22T10:45))
Map(SideStages(), CreateGroups(_333oh-r1, 3, 2027-07-22T09:00:01, 2027-07-22T09:55))

Map(HallA(), CreateGroups(_clock-r1, 4, 2027-07-22T10:45, 2027-07-22T12:15))
Map(HallBC(), CreateGroups(_clock-r1, 8, 2027-07-22T09:55, 2027-07-22T12:35))
Map(HallDE(), CreateGroups(_clock-r1, 6, 2027-07-22T09:55, 2027-07-22T11:55))

    CreateMiscActivity("Lunch", "other-lunch", "Hall A", 2027-07-22T12:15, 2027-07-22T13:15)
    CreateMiscActivity("Lunch", "other-lunch", "Hall BC", 2027-07-22T12:35, 2027-07-22T13:40)
    CreateMiscActivity("Lunch", "other-lunch", "Hall DE", 2027-07-22T11:55, 2027-07-22T12:50)

Map(HallA(), CreateGroups(_fto-r1, 3, 2027-07-22T13:15, 2027-07-22T14:25))
Map(HallBC(), CreateGroups(_fto-r1, 1, 2027-07-22T13:40, 2027-07-22T14:05))
Map(HallDE(), CreateGroups(_fto-r1, 3, 2027-07-22T12:50, 2027-07-22T14:05))

Map(HallA(), CreateGroups(_pyram-r1, 5, 2027-07-22T14:25, 2027-07-22T15:55))
Map(SideStages(), CreateGroups(_pyram-r1, 8, 2027-07-22T14:05, 2027-07-22T16:20))

Map(HallA(), CreateGroups(_555-r1, 3, 2027-07-22T15:55, 2027-07-22T17:15))
Map(HallBC(), CreateGroups(_555-r1, 2, 2027-07-22T16:20, 2027-07-22T17:15))
Map(HallDE(), CreateGroups(_555-r1, 3, 2027-07-22T16:20:01, 2027-07-22T17:35))

Map(HallA(), CreateGroups(_333oh-r2, 1, 2027-07-22T17:15, 2027-07-22T17:35))
Map(HallBC(), CreateGroups(_333oh-r2, 1, 2027-07-22T17:15, 2027-07-22T17:35))

Map(Stages(), CreateGroups(_clock-r2, 1, 2027-07-22T17:35, 2027-07-22T18:00))

    CreateMiscActivity("Opening Ceremony", "other-misc", "Hall A", 2027-07-22T18:15, 2027-07-22T19:00)
    CreateMiscActivity("Nations Cup", "other-misc", "Hall A", 2027-07-22T19:00, 2027-07-22T20:30)

# Friday

Map(HallA(), CreateGroups(_222-r1, 7, 2027-07-23T09:00, 2027-07-23T11:00))
Map(HallBC(), CreateGroups(_222-r1, 8, 2027-07-23T09:00:01, 2027-07-23T11:00))
Map(HallDE(), CreateGroups(_222-r1, 10, 2027-07-23T09:00:02, 2027-07-23T11:30))

Map(HallA(), CreateGroups(_555-r2, 1, 2027-07-23T11:00, 2027-07-23T11:30))
Map(HallBC(), CreateGroups(_555-r2, 1, 2027-07-23T11:00, 2027-07-23T11:30))

Map(Stages(), CreateGroups(_pyram-r2, 1, 2027-07-23T11:30, 2027-07-23T11:50))

    CreateMiscActivity("Lunch", "other-lunch", "Hall A", 2027-07-23T11:50, 2027-07-23T12:50)

Map(HallA(), CreateGroups(_444-r1, 5, 2027-07-23T12:50, 2027-07-23T14:40))
Map(HallBC(), CreateGroups(_444-r1, 9, 2027-07-23T11:50:01, 2027-07-23T15:50, [], true, true, [Tuple(1, 60)]))
Map(HallDE(), CreateGroups(_444-r1, 9, 2027-07-23T11:50:01, 2027-07-23T15:50, [], true, true, [Tuple(2, 60)]))

Map(HallA(), CreateGroups(_sq1-r1, 4, 2027-07-23T14:40, 2027-07-23T16:00))
Map(SideStages(), CreateGroups(_sq1-r1, 2, 2027-07-23T15:50, 2027-07-23T16:25))

Map(HallA(), CreateGroups(_666-r1, 2, 2027-07-23T16:00, 2027-07-23T16:45))
Map(SideStages(), CreateGroups(_666-r1, 1, 2027-07-23T16:25, 2027-07-23T16:50))

    # Finals Block

Map(HallA(), CreateGroups(_333oh-r3, 1, 2027-07-23T17:00, 2027-07-23T17:30))
Map(HallA(), CreateGroups(_fto-r2, 1, 2027-07-23T17:30, 2027-07-23T18:00))
Map(HallA(), CreateGroups(_pyram-r3, 1, 2027-07-23T18:00, 2027-07-23T18:30))
Map(HallA(), CreateGroups(_555-r3, 1, 2027-07-23T18:30, 2027-07-23T19:00))
Map(HallA(), CreateGroups(_clock-r3, 1, 2027-07-23T19:00, 2027-07-23T19:30))

# Saturday

Map(HallA(), CreateGroups(_skewb-r1, 7, 2027-07-24T09:00, 2027-07-24T11:00))
Map(HallBC(), CreateGroups(_skewb-r1, 8, 2027-07-24T09:00:01, 2027-07-24T11:00))
Map(HallDE(), CreateGroups(_skewb-r1, 9, 2027-07-24T09:00:02, 2027-07-24T11:20))

Map(HallA(), CreateGroups(_sq1-r2, 1, 2027-07-24T11:00, 2027-07-24T11:20))
Map(HallBC(), CreateGroups(_sq1-r2, 1, 2027-07-24T11:00, 2027-07-24T11:20))

Map(Stages(), CreateGroups(_444-r2, 1, 2027-07-24T11:20, 2027-07-24T11:40))

Map(Stages(), CreateGroups(_222-r2, 1, 2027-07-24T11:40, 2027-07-24T12:00))

    CreateMiscActivity("Lunch", "other-lunch", "Hall A", 2027-07-24T12:00, 2027-07-24T13:00)

Map(HallA(), CreateGroups(_333-r1, 6, 2027-07-24T13:00, 2027-07-24T14:45))
Map(HallBC(), CreateGroups(_333-r1, 11, 2027-07-24T12:00:01, 2027-07-24T16:05, [], true, true, [Tuple(1, 60)]))
Map(HallDE(), CreateGroups(_333-r1, 11, 2027-07-24T12:00:01, 2027-07-24T16:05, [], true, true, [Tuple(2, 60)]))

Map(HallA(), CreateGroups(_777-r1, 2, 2027-07-24T14:45, 2027-07-24T15:40))
Map(SideStages(), CreateGroups(_777-r1, 1, 2027-07-24T16:05, 2027-07-24T16:30))

Map(HallA(), CreateGroups(_333bf-r1, 3, 2027-07-24T15:40, 2027-07-24T17:00))
Map(SideStages(), CreateGroups(_333bf-r1, 1, 2027-07-24T16:30, 2027-07-24T17:00))

    # Finals Block

Map(HallA(), CreateGroups(_444-r3, 1, 2027-07-24T17:15, 2027-07-24T17:45))
Map(HallA(), CreateGroups(_sq1-r3, 1, 2027-07-24T17:45, 2027-07-24T18:15))
Map(HallA(), CreateGroups(_222-r3, 1, 2027-07-24T18:15, 2027-07-24T18:45))
Map(HallA(), CreateGroups(_666-r2, 1, 2027-07-24T18:45, 2027-07-24T19:15))

# Sunday

Map(HallA(), CreateGroups(_444bf-r1, 1, 2027-07-25T09:00, 2027-07-25T09:30))

Map(HallA(), CreateGroups(_minx-r1, 2, 2027-07-25T09:30, 2027-07-25T10:20))
Map(SideStages(), CreateGroups(_minx-r1, 3, 2027-07-25T09:00:01, 2027-07-25T10:10))

Map(HallA(), CreateGroups(_333-r2, 2, 2027-07-25T10:20, 2027-07-25T11:00))
Map(HallBC(), CreateGroups(_333-r2, 2, 2027-07-25T10:10, 2027-07-25T11:00))
Map(HallDE(), CreateGroups(_333-r2, 5, 2027-07-25T10:10:01, 2027-07-25T11:50))

Map(HallA(), CreateGroups(_333bf-r2, 1, 2027-07-25T11:00, 2027-07-25T11:25))
Map(HallBC(), CreateGroups(_333bf-r2, 1, 2027-07-25T11:00, 2027-07-25T11:25))

Map(HallA(), CreateGroups(_minx-r2, 1, 2027-07-25T11:25, 2027-07-25T11:50))
Map(HallBC(), CreateGroups(_minx-r2, 1, 2027-07-25T11:25, 2027-07-25T11:50))

Map(Stages(), CreateGroups(_skewb-r2, 1, 2027-07-25T11:50, 2027-07-25T12:10))

    CreateMiscActivity("Lunch", "other-lunch", "Hall A", 2027-07-25T12:10, 2027-07-25T13:10)

Map(HallA(), CreateGroups(_333-r3, 1, 2027-07-25T13:10, 2027-07-25T14:00))

    # Finals Block

Map(HallA(), CreateGroups(_777-r2, 1, 2027-07-25T14:00, 2027-07-25T14:30))
Map(HallA(), CreateGroups(_skewb-r3, 1, 2027-07-25T14:30, 2027-07-25T15:00))
Map(HallA(), CreateGroups(_minx-r3, 1, 2027-07-25T15:00, 2027-07-25T15:30))
Map(HallA(), CreateGroups(_333bf-r3, 1, 2027-07-25T15:30, 2027-07-25T16:00))

    # 3x3 Finals

Map(HallA(), CreateGroups(_333-r4, 8, 2027-07-25T16:15, 2027-07-25T17:55))

    CreateMiscActivity("Awards Ceremony", "other-awards", "Hall A", 2027-07-25T18:10, 2027-07-25T19:00)

    # Side Room Schedule

CreateGroups(_555bf-r1, 1, SIDE, 2027-07-22T09:00:02, 2027-07-22T10:10)
CreateGroups(_333mbf-r1-a1, 1, SIDE, 2027-07-22T15:00, 2027-07-22T16:20, useStageName=false)
CreateGroups(_333fm-r1-a1, 1, SIDE, 2027-07-23T09:05, 2027-07-23T10:20, useStageName=false)
CreateGroups(_333fm-r1-a2, 1, SIDE, 2027-07-23T12:50, 2027-07-23T14:05, useStageName=false)
CreateGroups(_333fm-r1-a3, 1, SIDE, 2027-07-23T14:05, 2027-07-23T15:20, useStageName=false)
CreateGroups(_333mbf-r1-a2, 1, SIDE, 2027-07-24T14:20, 2027-07-24T15:40, useStageName=false)
CreateGroups(_444bf-r1, 1, SIDE, 2027-07-25T09:00:02, 2027-07-25T09:45)