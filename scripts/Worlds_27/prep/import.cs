#include "../lib/_constants.cs"

# Change commentator to live stream everywhere

ReadSpreadsheet("1hzt0qfEeZ5FPLdn5FPcVabWG1jo2iEWmUcbO6GWxQKA/edit?gid=443044322#gid=443044322", offset=2, sheetTitle="For CompScript_1 (do not touch)")

# Set some derived properties.
DeleteRole(Persons(HasRole(DATAENTRY)), DATAENTRY)
AddRole(
    Persons(
        (StringProperty("staff-team-form") == "staff-dataentry")
    ), DATAENTRY)

DeleteProperty(Persons(HasProperty(STAGE_STAFF)), STAGE_STAFF)
SetProperty(
    Persons(
        (StringProperty("staff-team-form") == "stage-staff")
    ), STAGE_STAFF, true)

DeleteProperty(Persons(HasProperty(SIDE_ROOM_TEAM)), SIDE_ROOM_TEAM)
SetProperty(
    Persons(
        (StringProperty("staff-team-form") == "side-room")
    ), SIDE_ROOM_TEAM, 1)

DeleteProperty(Persons(HasProperty(LIVE_STREAM)), LIVE_STREAM)
SetProperty(
    Persons(
        (StringProperty("staff-team-form") == "live-stream")
    ), LIVE_STREAM, true)

DeleteProperty(Persons(HasProperty(STAGE_LEAD)), STAGE_LEAD)
SetProperty([2010AMBR01, 2008YOUN02, 2013DICK01, 2014NIEL03, 2020LONG05, 2017WOFF01, 2015COHE02, 2015ROYC01],
            STAGE_LEAD, true)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-judge", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-scrambler", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-runner", 5)
SetProperty(Persons(BooleanProperty(STAGE_LEAD)), "percent-Delegate", 100)

DeleteProperty(Persons(HasProperty(WCA_BOARD)), WCA_BOARD)
SetProperty(Filter([2014PRID01, 2010THOM03, 2019JARM01, 2016CHAI03, 2016SILV08], Not(IsNull(Arg<Person>()))), WCA_BOARD, true)

DeleteProperty(Persons(HasProperty(WCA_BOOTH)), WCA_BOOTH)
SetProperty([2008CLEM01, 2013KLEM01], WCA_BOOTH, true)

DeleteProperty(Persons(HasProperty(REG)), REG)
SetProperty(
    Persons(
        (StringProperty("staff-team-form") == "registration")
    ), REG, true)