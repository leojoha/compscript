#include "../lib/_constants.cs"
#include "../lib/_eligible_scramblers.cs"
#include "../lib/_is_delegate.cs"
#include "../_import.cs"

Define(
    "BasicConstraints",
    [
      BalanceConstraint("Num Events", Length(RegisteredEvents()), 0.2),
      LimitConstraint("Stage Leads", HasProperty(STAGE_LEAD), 2, 10),
      BalanceConstraint("delegate", IsDelegate(), 1)
    ])

Define(
    "PreferenceConstraints",
    Map(["judge", "scrambler", "runner"],
        BalanceConstraint((Arg<String>() + " Preference"), NumberProperty(("percent-" + Arg<String>())), 1)))

Define(
    "ScramblerConstraints",
    Concat(
      Map(
        [_555, _666, _777, _minx, _sq1, _clock],
        LimitConstraint((EventId() + " scramblers"), And(CanScramble(Arg<Event>()),
                                                         Not(HasRole("delegate"))), 8, 5)),
      Map(
        [_555, _minx, _sq1, _clock],
        LimitConstraint((EventId() + " semi scramblers"), And(CanScramble(Arg<Event>()),
                                                              (PsychSheetPosition() > 150),
                                                              Not(HasRole("delegate"))), 5, 10))))

Define(
    "RoundOneConstraints",
    Concat(Map([_333, _222, _444, _pyram, _skewb, _333oh],
               BalanceConstraint(EventId(), CompetingIn(), 0.05)),
           Map([_555, _666, _777, _333bf, _clock, _sq1, _minx],
               BalanceConstraint(EventId(), CompetingIn(), 0.1)),
           [BalanceConstraint("555bf", (PsychSheetPosition(_555bf) <= 70), 3),
            BalanceConstraint("444bf", (PsychSheetPosition(_444bf) <= 70), 3),
            BalanceConstraint("333fm", (PsychSheetPosition(_333fm) <= 100), 3),
            BalanceConstraint("333mbf", (PsychSheetPosition(_333mbf) <= 50), 3)]))

Define(
    "RoundTwoConstraints",
    Map([_333, _222],
        BalanceConstraint((EventId() + "-r2"), (PsychSheetPosition() < 500), 0.1)))

Define(
    "SemiConstraints",
    Map([_333, _222, _444, _555, _666, _777, _333bf, _333oh, _clock, _pyram, _skewb, _sq1, _minx],
      BalanceConstraint((EventId() + "-semi"), (PsychSheetPosition() < 125), 2)))

DeleteProperty(Persons(HasProperty(STAFF_TEAM)), STAFF_TEAM)

Cluster(
    STAFF_TEAM, 10, Persons(BooleanProperty(STAGE_STAFF)),
    StringProperty("staff-team-id"),
    Concat(
      BasicConstraints(),
      PreferenceConstraints(),
      ScramblerConstraints(),
      RoundOneConstraints(),
      RoundTwoConstraints(),
      SemiConstraints()))

DeleteProperty(Persons(HasProperty(SIDE_ROOM_TEAM)), SIDE_ROOM_TEAM)

SetProperty(
    Persons(
        (StringProperty("staff-team-form") == "side-room")
    ), SIDE_ROOM_TEAM, 1)

"Side room team 1"
All(1, Persons((NumberProperty(SIDE_ROOM_TEAM) == 1)))