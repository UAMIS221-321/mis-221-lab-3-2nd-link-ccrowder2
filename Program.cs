// start main

string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);

DisplayStadiumDetails(stadium, game);

// end main

static string GetEnjoymentLevel(){
    Console.Clear();
System.Console.WriteLine("What is your preferred enjoyment level for the game you want to attend?");
return Console.ReadLine();
}

static string GetStadiumRecommendation(string enjoymentLevel){   
    if(enjoymentLevel.ToLower() == "boring"){
        return "Neyland Stadium";
    } else if (enjoymentLevel.ToLower() == "average"){
        return "Jordan-Hare Stadium";
    } else if (enjoymentLevel.ToLower() == "fun"){
        return "Tiger Stadium";
    } else if (enjoymentLevel.ToLower() == "epic"){
        return "Saban Field at Bryant-Denny Stadium";
    } else {
        return "Invalid input";
    }    
}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "vs Kent State";
    } else if (stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    } else if (stadium == "Tiger Stadium"){
        return "vs Alabama";
    } else if (stadium == "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    } else {
        return "";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    if(stadium == "Invalid input"){
        System.Console.WriteLine("Invalid input.");
    } else {
        System.Console.WriteLine($"The best stadium for you is {stadium}, the best game to attend is {game}.");
    }
}