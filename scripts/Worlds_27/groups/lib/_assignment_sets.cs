#include "../../lib/_assigned_stage.cs"
#include "../../lib/_eligible_scramblers.cs"
#include "../../lib/_constants.cs"

# Args:
# 1: Event
# 2: Number of top people
Define(
  "TopCompetitors",
  [AssignmentSet("top",
                 (PsychSheetPosition({1, Event}) <= {2, Number}),
                 In(Stage(), HallA()),
                 featured=true)])

Define(
  "EarlyAssignmentSets",
  [AssignmentSet("data", HasRole(DATAENTRY), (Stage() == YELLOW)),
   AssignmentSet("commentators", BooleanProperty(LIVE_STREAM), (Stage() == BLUE)),
   AssignmentSet("wca-booth", BooleanProperty(WCA_BOOTH), (Stage() == PURPLE))])

# Args:
# 1: Event
# 2: Date
Define(
  "StaffAssignmentSets",
  Flatten(Map(
    Stages(),
    [AssignmentSet(("stage-leads-" + Arg<String>()),
                   And(BooleanProperty(STAGE_LEAD),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("scramblers-" + Arg<String>()),
                   And(CanScramble({1, Event}),
                       (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>())),
                   (Stage() == Arg<String>())),
     AssignmentSet(("staff-" + Arg<String>()),
                   (AssignedStage(Arg<Person>(), {2, Date}) == Arg<String>()),
                   (Stage() == Arg<String>()))])))

Define("EveryoneAssignmentSets",  [AssignmentSet("everyone", true, true)])

Define("RoundOneAssignmentSets",
       Concat(
         TopCompetitors({1, Event},
                        (2 * Length(Filter(Groups(RoundForEvent(1, {1, Event})),
                                           In(Stage(Arg<Group>()), HallA()))))),
         EarlyAssignmentSets(),
         StaffAssignmentSets({1, Event}, {2, Date}),
         EveryoneAssignmentSets()))

Define("RoundTwoAssignmentSets",
       [AssignmentSet("Top",
                      (RoundPosition(PreviousRound({1, Round})) <= 4),
                      And(In(Stage(), HallA()), (GroupNumber() == 5)),
                      featured=true),
        AssignmentSet("Five", (RoundPosition(PreviousRound({1, Round})) <= 80), (GroupNumber() == 5)),
        AssignmentSet("Four", (RoundPosition(PreviousRound({1, Round})) <= 160), (GroupNumber() == 4)),
        AssignmentSet("Three", (RoundPosition(PreviousRound({1, Round})) <= 240), (GroupNumber() == 3)),
        AssignmentSet("Two", (RoundPosition(PreviousRound({1, Round})) <= 320), (GroupNumber() == 2)),
        AssignmentSet("One", (RoundPosition(PreviousRound({1, Round})) <= 400), (GroupNumber() == 1))])

Define("SemifinalAssignmentSets",
       [AssignmentSet("Top",
                      (RoundPosition(PreviousRound({1, Round})) <= 4),
                      In(Stage(), HallA()),
                      featured=true),
        AssignmentSet("Everyone", true, true)])

Define("FinalsAssignmentSets",
       [AssignmentSet("Evens", Even(RoundPosition(PreviousRound({1, Round}))), (Stage() == BLUE)),
        AssignmentSet("Odds", Not(Even(RoundPosition(PreviousRound({1, Round})))), (Stage() == YELLOW))])