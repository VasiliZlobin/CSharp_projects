void CheckStatementTwoBool(bool first, bool second)
{
    Console.WriteLine($"!({first} || {second}) = {!(first || second)}, !{first} && !{second} = {!first && !second}");
}

CheckStatementTwoBool(false, false);
CheckStatementTwoBool(false, true);
CheckStatementTwoBool(true, false);
CheckStatementTwoBool(true, true);