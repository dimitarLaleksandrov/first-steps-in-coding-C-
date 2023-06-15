//Resharper disable InconsistentNaming, CheckNamespace

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using AutoMapper;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using NUnit.Framework;

using Boardgames;
using Boardgames.Data;

[TestFixture]
public class Import_000_002
{
    private IServiceProvider serviceProvider;

    private static readonly Assembly CurrentAssembly = typeof(StartUp).Assembly;

    [SetUp]
    public void Setup()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<BoardgamesProfile>();
        });

        this.serviceProvider = ConfigureServices<BoardgamesContext>("Boardgames");
    }

    [Test]
    public void ImportSellersZeroTest()
    {
        var context = this.serviceProvider.GetService<BoardgamesContext>();

        SeedDatabase(context);

        var inputJson = "[{\"Name\":\"6am\",\"Address\":\"The Netherlands\",\"Country\":\"Belgium\",\"Website\":\"www.6pm.com\",\"Boardgames\":[1,105,1,5,15]},{\"Name\":\"Asurion, LLC\",\"Address\":\"P.O. Box 234,  38-54\",\"Country\":\"Belgium\",\"Website\":\"www.asurion-llc.com\",\"Boardgames\":[1,85,81,80,5,9]},{\"Name\":\"Bedsure\",\"Address\":\"P.O. Box 601, 685\",\"Country\":\"United States\",\"Website\":\"www.bedsure.com\",\"Boardgames\":[3,9,15,5,11,10,5,5]},{\"Name\":\"Book Depository US\",\"Address\":\"4722 Enim. Rd., 9745\",\"Country\":\"United States\",\"Website\":\"www.bookdepositoryus.com\",\"Boardgames\":[100,64,89,95]},{\"Name\":\"Carlyle\",\"Address\":\"\",\"Country\":\"United States\",\"Website\":\"www.carlyle.com\",\"Boardgames\":[54,59,49,48,59,58,53,53,46,46,54,56,55,54,47]},{\"Name\":\"\",\"Address\":\"1885 Commodo Av.,  14010-00111\",\"Country\":\"France\",\"Website\":\"www.commoncentsdistributors.com\",\"Boardgames\":[3,20,41,4,79,28,72,89,31,83,8,15,38,83,56,71,95]},{\"Name\":\"EPFamily Direct\",\"Address\":\"6620 Donec St., 12893\",\"Country\":\"France\",\"Website\":\"www.epfamily direct.com\",\"Boardgames\":[100,66,78,95,41,98,55,100]},{\"Name\":\"eSupplements\",\"Address\":\"8401 Cras Rd.,  1852-6795\",\"Country\":\"United Kingdom\",\"Website\":\"www.esupplements.com\",\"Boardgames\":[1,8,9,2,14,9,3,14,6,14,6,5,2,1]},{\"Name\":\"Fintie\",\"Address\":\"8158 In, 2016\",\"Country\":\"\",\"Website\":\"www.fintie.com\",\"Boardgames\":[10,2,7,6,4,4,12,5,11]},{\"Name\":\"Galactic Shop\",\"Address\":\"579-9592 Massa. Av.,  78-12\",\"Country\":\"United Kingdom\",\"Website\":\"www.galacticshop.com\",\"Boardgames\":[78,62,72,64,72,80,66,63,63,60,61,76]},{\"Name\":\"\",\"Address\":\"P.O. Box 226, 48856\",\"Country\":\"\",\"Website\":\"www.glenthebookseller.com\",\"Boardgames\":[39,35,43,38,40,32,35,36,43,40,34,37,31,38,34]},{\"Name\":\"GORILLA COMMERCE\",\"Address\":\"Ap #330-4046 Rutrum St., 15138\",\"Country\":\"United States\",\"Website\":\"www.gorilla commerce.com\",\"Boardgames\":[96,11,74,73,8,90]},{\"Name\":\"Hey Dude Official\",\"Address\":\"2062 Sit St.,  67-662\",\"Country\":\"United States\",\"Website\":\"www.heydudeofficial.com\",\"Boardgames\":[75,23,44,56,33,4,96,7]},{\"Name\":\"HLmedical\",\"Address\":\"997-1119 Et Street, 99636\",\"Country\":\"United States\",\"Website\":\"\",\"Boardgames\":[28,27,27,26,26,19]},{\"Name\":\"Hour Loop\",\"Address\":\"Ap #479-8106 Est St.,  61832-815\",\"Country\":\"Ireland\",\"Website\":\"www.hour loop.com\",\"Boardgames\":[100,55,42,66,51,70,88,100]},{\"Name\":\"JE Products US\",\"Address\":\"2689 Duis Avenue, 72421\",\"Country\":\"the Netherlands\",\"Website\":\"www.jeproductsus.com\",\"Boardgames\":[73,60,69,52,46,76]},{\"Name\":\"LiCB\",\"Address\":\"847-7755 Vestibulum St., 21102\",\"Country\":\"Norway\",\"Website\":\"www.licb.com\",\"Boardgames\":[5,38,18,89,2,31,43,63,2]},{\"Name\":\"Lume Deodorant LLC\",\"Address\":\"\",\"Country\":\"Norway\",\"Website\":\"www.lume deodorant llc.com\",\"Boardgames\":[77,64,91,39,11,42,55,83,14,34,65]},{\"Name\":\"LY Berditchev Co.\",\"Address\":\"Ap #211-1984 Nulla Av.,  22414-119\",\"Country\":\"Norway\",\"Website\":\"www.lyberditchevco..com\",\"Boardgames\":[21,20,22,7,32,9,40,45,63,19]},{\"Name\":\"Mr. Medical\",\"Address\":\"Ap #527-9909 Ullamcorper, 30154\",\"Country\":\"Norway\",\"Website\":\"www.mrmedical.com\",\"Boardgames\":[5,50,75,20,41,12,18,20,83]},{\"Name\":\"Mr. Pen\",\"Address\":\"473-8232 Mattis Avenue, 50545\",\"Country\":\"Norway\",\"Website\":\"www.mrpen.com\",\"Boardgames\":[6,90,75,85,80]},{\"Name\":\"MYBATTERYSUPPLIER\",\"Address\":\"Ap #624-3901 Non,  67-662\",\"Country\":\"United States\",\"Website\":\"www.mybatterysupplier.com\",\"Boardgames\":[2,57,84,67,68]},{\"Name\":\"Orva Stores\",\"Address\":\"Ap #496-3968 Nibh. Av., 16671\",\"Country\":\"United States\",\"Website\":\"www.orva stores.com\",\"Boardgames\":[76,59,66,10,92,73,73,93,98,96]},{\"Name\":\"OxKom\",\"Address\":\"989-4640 Blandit St., 66848\",\"Country\":\"\",\"Website\":\"www.oxkom.com\",\"Boardgames\":[10,5,5,8,3,4,12,3,10]},{\"Name\":\"Pattern.\",\"Address\":\"Ap #905-2113 Nibh. Rd., 26622\",\"Country\":\"Poland\",\"Website\":\"www.pattern..com\",\"Boardgames\":[95,94,73,91]},{\"Name\":\"\",\"Address\":\"142-9837 Tortor Av.,  1157-3790\",\"Country\":\"Poland\",\"Website\":\"www.petco.com\",\"Boardgames\":[18,23,29,16,17,21,30]},{\"Name\":\"recommerce\",\"Address\":\"685 Non Rd.,  53880-04637\",\"Country\":\"Poland\",\"Website\":\"www.recommerce.com\",\"Boardgames\":[3,38,86,14,52,82,24,25]},{\"Name\":\"River Colony Trading\",\"Address\":\"Ap #344-2877 Dolor. Rd., 27295\",\"Country\":\"Germany\",\"Website\":\"www.river colony trading.com\",\"Boardgames\":[85,85,82,52,55,91,84]},{\"Name\":\"Spigen Inc\",\"Address\":\"P.O. Box 423, 275214\",\"Country\":\"Germany\",\"Website\":\"www.spigeninc.com\",\"Boardgames\":[75,94,75,11,13,82]}]";
        var actualOutput =
            Boardgames.DataProcessor.Deserializer.ImportSellers(context, inputJson).TrimEnd();

        var expectedOutput =
            "Invalid data!\r\nInvalid data!\r\nSuccessfully imported seller - Asurion, LLC with 5 boardgames.\r\nSuccessfully imported seller - Bedsure with 6 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - Book Depository US with 1 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - eSupplements with 8 boardgames.\r\nInvalid data!\r\nSuccessfully imported seller - Galactic Shop with 10 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - Hey Dude Official with 7 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - JE Products US with 6 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - Mr. Pen with 3 boardgames.\r\nInvalid data!\r\nSuccessfully imported seller - MYBATTERYSUPPLIER with 4 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - recommerce with 6 boardgames.\r\nInvalid data!\r\nInvalid data!\r\nInvalid data!\r\nSuccessfully imported seller - Spigen Inc with 3 boardgames.";

        var assertContext = this.serviceProvider.GetService<BoardgamesContext>();

        const int expectedSellersCount = 11;
        var actualSellersCount = assertContext.Sellers.Count();

        const int expectedBoardgamesSellersCount = 59;
        var actualBoardgamesSellersCount = assertContext.BoardgamesSellers.Count();

        Assert.That(actualBoardgamesSellersCount, Is.EqualTo(expectedBoardgamesSellersCount),
            $"Inserted {nameof(context.BoardgamesSellers)} count is incorrect!");

        Assert.That(actualSellersCount, Is.EqualTo(expectedSellersCount),
            $"Inserted {nameof(context.Sellers)} count is incorrect!");

        Assert.That(actualOutput, Is.EqualTo(expectedOutput).NoClip,
            $"{nameof(Boardgames.DataProcessor.Deserializer.ImportSellers)} output is incorrect!");
    }

    private static void SeedDatabase(BoardgamesContext context)
    {
        var datasetsJson = "{\"Creator\":[{\"Id\":1,\"FirstName\":\"Debra\",\"LastName\":\"Edwards\"},{\"Id\":2,\"FirstName\":\"Vance\",\"LastName\":\"Welch\"},{\"Id\":3,\"FirstName\":\"Tatum\",\"LastName\":\"Hobbs\"},{\"Id\":4,\"FirstName\":\"Craig\",\"LastName\":\"Clayton\"},{\"Id\":5,\"FirstName\":\"Cole\",\"LastName\":\"Soto\"},{\"Id\":6,\"FirstName\":\"Lenore\",\"LastName\":\"Gamble\"},{\"Id\":7,\"FirstName\":\"Hope\",\"LastName\":\"Horton\"},{\"Id\":8,\"FirstName\":\"Shaine\",\"LastName\":\"Greer\"},{\"Id\":9,\"FirstName\":\"Mia\",\"LastName\":\"Short\"},{\"Id\":10,\"FirstName\":\"Regina\",\"LastName\":\"Bailey\"},{\"Id\":11,\"FirstName\":\"Desirae\",\"LastName\":\"Talley\"},{\"Id\":12,\"FirstName\":\"Cade\",\"LastName\":\"O'Neill\"},{\"Id\":13,\"FirstName\":\"Belle\",\"LastName\":\"Morales\"},{\"Id\":14,\"FirstName\":\"Fuller\",\"LastName\":\"Bridges\"},{\"Id\":15,\"FirstName\":\"Hop\",\"LastName\":\"Griffin\"},{\"Id\":16,\"FirstName\":\"Carl\",\"LastName\":\"Lowe\"},{\"Id\":17,\"FirstName\":\"Naida\",\"LastName\":\"Herrera\"},{\"Id\":18,\"FirstName\":\"Rowan\",\"LastName\":\"Carney\"},{\"Id\":19,\"FirstName\":\"Hop\",\"LastName\":\"Key\"}],\"Boardgame\":[{\"Id\":1,\"Name\":\"Kingdom Defenders\",\"Rating\":7.52,\"Mechanics\":\"Deduction, Hexagon Grid, Modular Board, Pattern Recognition\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":2,\"Name\":\"Kingdomino\",\"Rating\":7.06,\"Mechanics\":\"Connections, Tile Placement\",\"YearPublished\":2021,\"CategoryType\":0},{\"Id\":3,\"Name\":\"Kings Road\",\"Rating\":7.48,\"Mechanics\":\"Card Drafting, End Game Bonuses, Memory, Set Collection, Simultaneous Action Selection\",\"YearPublished\":2022,\"CategoryType\":4},{\"Id\":4,\"Name\":\"Mini Rails\",\"Rating\":7.68,\"Mechanics\":\"Drafting, End Game Bonuses, Hand Management, Tile Placement, Worker Placement\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":5,\"Name\":\"Capital Lux\",\"Rating\":7.58,\"Mechanics\":\"Grid Movement, Tile Placement\",\"YearPublished\":2023,\"CategoryType\":0},{\"Id\":6,\"Name\":\"Matryoshka\",\"Rating\":6.78,\"Mechanics\":\"Pattern Recognition\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":7,\"Name\":\"Pędzące Ślimaki\",\"Rating\":7.42,\"Mechanics\":\"Drafting, End Game Bonuses, Modular Board, Pattern Building, Set Collection, Tile Placement, Turn Order: Claim Action\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":8,\"Name\":\"Frogriders\",\"Rating\":6.71,\"Mechanics\":\"Modular Board, Pattern Building, Tile Placement\",\"YearPublished\":2022,\"CategoryType\":4},{\"Id\":9,\"Name\":\"Imperial Struggle\",\"Rating\":7.19,\"Mechanics\":\"Card Drafting, Dice Rolling, Drafting, Set Collection, Simultaneous Action Selection\",\"YearPublished\":2021,\"CategoryType\":2},{\"Id\":10,\"Name\":\"Nerdy Inventions\",\"Rating\":7.1,\"Mechanics\":\"Hand Management, Pattern Building\",\"YearPublished\":2021,\"CategoryType\":0},{\"Id\":11,\"Name\":\"The Fog of War\",\"Rating\":9.65,\"Mechanics\":\"Grid Movement, Hand Management, Rock-Paper-Scissors, Time Track, Variable Player Powers\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":12,\"Name\":\"Warlords of Europe\",\"Rating\":4.58,\"Mechanics\":\"Dice Rolling\",\"YearPublished\":2020,\"CategoryType\":1},{\"Id\":13,\"Name\":\"Whistle Stop\",\"Rating\":7.01,\"Mechanics\":\"Memory\",\"YearPublished\":2020,\"CategoryType\":2},{\"Id\":14,\"Name\":\"South China Sea\",\"Rating\":8.19,\"Mechanics\":\"Action Drafting, Events, Point to Point Movement, Tech Trees / Tech Tracks, Worker Placement\",\"YearPublished\":2019,\"CategoryType\":4},{\"Id\":15,\"Name\":\"Star Wars: Rebellion\",\"Rating\":6.19,\"Mechanics\":\"Action Queue, Modular Board\",\"YearPublished\":2022,\"CategoryType\":0},{\"Id\":16,\"Name\":\"The Arrival\",\"Rating\":8.54,\"Mechanics\":\"Communication Limits, Cooperative Game, Grid Movement, Pattern Building\",\"YearPublished\":2023,\"CategoryType\":0},{\"Id\":17,\"Name\":\"Battle of Britain\",\"Rating\":6.97,\"Mechanics\":\"Worker Placement\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":18,\"Name\":\"Pandemic: Iberia\",\"Rating\":8.1,\"Mechanics\":\"Action Queue, Action Retrieval, Area Majority / Influence, Area Movement, Dice Rolling, Hand Management, Point to Point Movement, Race, Variable Player Powers\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":19,\"Name\":\"Adrenaline\",\"Rating\":7.63,\"Mechanics\":\"Action Points, Area Majority / Influence, Hexagon Grid, Tile Placement\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":20,\"Name\":\"Century: Spice Road\",\"Rating\":7.63,\"Mechanics\":\"Area Majority / Influence, Flicking, Variable Player Powers, Voting\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":21,\"Name\":\"Dice Forge\",\"Rating\":9.65,\"Mechanics\":\"Tile Placement, Worker Placement\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":22,\"Name\":\"Tokyo Highway\",\"Rating\":7.75,\"Mechanics\":\"Action Drafting, Commodity Speculation, Contracts, Market, Network and Route Building, Tile Placement, Turn Order: Claim Action\",\"YearPublished\":2022,\"CategoryType\":4},{\"Id\":23,\"Name\":\"Conejos en el Huerto\",\"Rating\":7.8,\"Mechanics\":\"Card Drafting, Hand Management, Race, Take That, Turn Order: Pass Order, Variable Player Powers\",\"YearPublished\":2021,\"CategoryType\":4},{\"Id\":24,\"Name\":\"Star Wars: Destiny\",\"Rating\":6.34,\"Mechanics\":\"Dice Rolling\",\"YearPublished\":2019,\"CategoryType\":1},{\"Id\":25,\"Name\":\"Thunder in the East\",\"Rating\":7.73,\"Mechanics\":\"Hexagon Grid, Trading\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":26,\"Name\":\"Bloody Monday\",\"Rating\":9.66,\"Mechanics\":\"Trick-taking\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":27,\"Name\":\"DOOM: The Board Game\",\"Rating\":6.76,\"Mechanics\":\"Roll / Spin and Move, Worker Placement\",\"YearPublished\":2019,\"CategoryType\":1},{\"Id\":28,\"Name\":\"Fields of Green\",\"Rating\":7.6,\"Mechanics\":\"Area Majority / Influence, Card Play Conflict Resolution, Hand Management\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":29,\"Name\":\"Photosynthesis\",\"Rating\":7.63,\"Mechanics\":\"Ownership, Turn Order: Claim Action, Turn Order: Pass Order, Variable Set-up, Worker Placement\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":30,\"Name\":\"TOP Kitchen\",\"Rating\":7.1,\"Mechanics\":\"Dice Rolling, Legacy Game\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":31,\"Name\":\"A Handful of Stars\",\"Rating\":8.66,\"Mechanics\":\"Hand Management, Income, Loans, Market, Network and Route Building, Score-and-Reset Game, Tech Trees / Tech Tracks, Turn Order: Stat-Based, Variable Set-up\",\"YearPublished\":2021,\"CategoryType\":4},{\"Id\":32,\"Name\":\"Enchanters\",\"Rating\":8.18,\"Mechanics\":\"Card Drafting, Deck Bag and Pool Building, Hand Management, Set Collection\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":33,\"Name\":\"Rising Sun\",\"Rating\":7.03,\"Mechanics\":\"Deduction, Hidden Roles, Set Collection\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":34,\"Name\":\"Via Nebula\",\"Rating\":7.1,\"Mechanics\":\"Memory, Pick-up and Deliver\",\"YearPublished\":2018,\"CategoryType\":1},{\"Id\":35,\"Name\":\"Go Go Gelato!\",\"Rating\":7.37,\"Mechanics\":\"Area Majority / Influence, Auction/Bidding, Modular Board, Worker Placement\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":36,\"Name\":\"Legendary Inventors\",\"Rating\":7.17,\"Mechanics\":\"Card Drafting, Hand Management, Set Collection\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":37,\"Name\":\"Meeple Circus\",\"Rating\":6.38,\"Mechanics\":\"Area Majority / Influence, Tile Placement\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":38,\"Name\":\"Round House\",\"Rating\":7.31,\"Mechanics\":\"Card Drafting, Drafting, Set Collection\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":39,\"Name\":\"The Shipwreck Arcana\",\"Rating\":7.29,\"Mechanics\":\"Cooperative Game, Hand Management, Trick-taking\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":40,\"Name\":\"Copper Country\",\"Rating\":6.49,\"Mechanics\":\"Enclosure, Tile Placement\",\"YearPublished\":2018,\"CategoryType\":0},{\"Id\":41,\"Name\":\"Fabled Fruit\",\"Rating\":7.1,\"Mechanics\":\"Card Drafting, Rondel, Set Collection, Tile Placement, Variable Player Powers\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":42,\"Name\":\"Planet Rush\",\"Rating\":7.19,\"Mechanics\":\"Card Drafting, Set Collection\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":43,\"Name\":\"Thunderstone Quest\",\"Rating\":6.84,\"Mechanics\":\"Hand Management, Modular Board, Tile Placement, Variable Player Powers\",\"YearPublished\":2022,\"CategoryType\":4},{\"Id\":44,\"Name\":\"Wiener Walzer\",\"Rating\":8.44,\"Mechanics\":\"Hand Management, Memory, Take That\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":45,\"Name\":\"Bohnanza: The Duel\",\"Rating\":7.32,\"Mechanics\":\"Pattern Building, Set Collection\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":46,\"Name\":\"Great Western Trail\",\"Rating\":6.92,\"Mechanics\":\"Cooperative Game, Hand Management, Real-Time, Variable Player Powers\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":47,\"Name\":\"Indulgence\",\"Rating\":7.48,\"Mechanics\":\"Area Majority / Influence, Betting and Bluffing, Hidden Victory Points, Take That\",\"YearPublished\":2021,\"CategoryType\":4},{\"Id\":48,\"Name\":\"Risk Europe\",\"Rating\":6.38,\"Mechanics\":\"Modular Board, Set Collection\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":49,\"Name\":\"The Grimm Forest\",\"Rating\":7.55,\"Mechanics\":\"Card Drafting, Pattern Building, Set Collection, Tile Placement\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":50,\"Name\":\"Whitehall Mystery\",\"Rating\":6.72,\"Mechanics\":\"Dice Rolling, Paper-and-Pencil\",\"YearPublished\":2023,\"CategoryType\":1},{\"Id\":51,\"Name\":\"Mise: Kolonizace\",\"Rating\":7.52,\"Mechanics\":\"Card Drafting, Dice Rolling, Follow, Set Collection, Worker Placement\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":52,\"Name\":\"My First Stone Age\",\"Rating\":7.89,\"Mechanics\":\"Cooperative Game, Dice Rolling, Legacy Game, Point to Point Movement, Variable Player Powers\",\"YearPublished\":2018,\"CategoryType\":1},{\"Id\":53,\"Name\":\"Animals on Board\",\"Rating\":7.18,\"Mechanics\":\"Area Majority / Influence, Dice Rolling, Push Your Luck, Set Collection, Take That, Worker Placement\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":54,\"Name\":\"Gold Armada\",\"Rating\":7.61,\"Mechanics\":\"Area Majority / Influence, Card Drafting, Hand Management, Network and Route Building\",\"YearPublished\":2020,\"CategoryType\":4},{\"Id\":55,\"Name\":\"Mystic Vale\",\"Rating\":7.07,\"Mechanics\":\"Contracts, Pattern Building, Set Collection, Tile Placement\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":56,\"Name\":\"Pioneer Days\",\"Rating\":7.31,\"Mechanics\":\"Area Movement, Hand Management, Interrupts, Kill Steal, Secret Unit Deployment, Variable Player Powers\",\"YearPublished\":2022,\"CategoryType\":4},{\"Id\":57,\"Name\":\"1920 Wall Street\",\"Rating\":7.79,\"Mechanics\":\"Auction/Bidding, Auction: Fixed Placement, Constrained Bidding, Income, Network and Route Building, Stock Holding, Turn Order: Claim Action, Turn Order: Progressive, Worker Placement\",\"YearPublished\":2020,\"CategoryType\":4},{\"Id\":58,\"Name\":\"Bears vs Babies\",\"Rating\":9.67,\"Mechanics\":\"Drafting, Grid Movement, Push Your Luck, Set Collection\",\"YearPublished\":2023,\"CategoryType\":2},{\"Id\":59,\"Name\":\"HMS Dolores\",\"Rating\":6.83,\"Mechanics\":\"Hand Management, Memory, Set Collection, Variable Player Powers\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":60,\"Name\":\"Jump Drive\",\"Rating\":6.6,\"Mechanics\":\"Auction/Bidding, Hand Management, Simultaneous Action Selection, Variable Player Powers\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":61,\"Name\":\"Lorenzo il Magnifico\",\"Rating\":6.84,\"Mechanics\":\"Area Movement, Worker Placement\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":62,\"Name\":\"Napoléon 1806\",\"Rating\":7.26,\"Mechanics\":\"Mancala, Worker Placement, Worker Placement, Different Worker Types\",\"YearPublished\":2019,\"CategoryType\":4},{\"Id\":63,\"Name\":\"An Infamous Traffic\",\"Rating\":6.9,\"Mechanics\":\"Dice Rolling\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":64,\"Name\":\"Android: Mainframe\",\"Rating\":6.68,\"Mechanics\":\"Memory, Pattern Recognition\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":65,\"Name\":\"Hero Realms\",\"Rating\":7.55,\"Mechanics\":\"Dice Rolling, Legacy Game, Scenario / Mission / Campaign Game, Worker Placement, Worker Placement with Dice Workers\",\"YearPublished\":2023,\"CategoryType\":4},{\"Id\":66,\"Name\":\"Rival Kings\",\"Rating\":6.77,\"Mechanics\":\"Memory, Push Your Luck\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":67,\"Name\":\"Alicematic Heroes\",\"Rating\":7.37,\"Mechanics\":\"Rondel, Tile Placement, Time Track, Variable Set-up\",\"YearPublished\":2020,\"CategoryType\":4},{\"Id\":68,\"Name\":\"Armageddon\",\"Rating\":7.1,\"Mechanics\":\"Action Points, Deck Bag and Pool Building, Drafting, End Game Bonuses, Grid Movement, Layering, Tile Placement\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":69,\"Name\":\"Fight for Olympus\",\"Rating\":7.22,\"Mechanics\":\"Hand Management, Modular Board, Race, Set Collection\",\"YearPublished\":2021,\"CategoryType\":2},{\"Id\":70,\"Name\":\"Meeple War\",\"Rating\":6.56,\"Mechanics\":\"Push Your Luck, Set Collection\",\"YearPublished\":2021,\"CategoryType\":2},{\"Id\":71,\"Name\":\"Nemesis: Burma 1944\",\"Rating\":7.55,\"Mechanics\":\"Action Points, Area Majority / Influence, Dice Rolling, Follow, Hand Management, Modular Board, Pick-up and Deliver, Point to Point Movement, Variable Player Powers\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":72,\"Name\":\"The Banishing\",\"Rating\":7.7,\"Mechanics\":\"Bias, Card Drafting, Worker Placement\",\"YearPublished\":2019,\"CategoryType\":4},{\"Id\":73,\"Name\":\"Bohemian Villages\",\"Rating\":6.76,\"Mechanics\":\"Drafting, Tile Placement, Turn Order: Progressive\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":74,\"Name\":\"Cinco Linko\",\"Rating\":7.16,\"Mechanics\":\"Dice Rolling, Drafting\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":75,\"Name\":\"Costa Rica\",\"Rating\":7.08,\"Mechanics\":\"Tile Placement\",\"YearPublished\":2022,\"CategoryType\":2},{\"Id\":76,\"Name\":\"Incorporated\",\"Rating\":6.52,\"Mechanics\":\"Dice Rolling, Set Collection\",\"YearPublished\":2019,\"CategoryType\":2},{\"Id\":77,\"Name\":\"Khan of Khans\",\"Rating\":8.02,\"Mechanics\":\"Commodity Speculation, Dice Rolling, Grid Movement, Market, Rondel, Set Collection, Tile Placement, Time Track\",\"YearPublished\":2019,\"CategoryType\":4},{\"Id\":78,\"Name\":\"Mole Rats in Space\",\"Rating\":7.51,\"Mechanics\":\"Auction/Bidding, Auction: Sealed Bid, End Game Bonuses, Memory, Set Collection\",\"YearPublished\":2019,\"CategoryType\":3},{\"Id\":79,\"Name\":\"Pixie Queen\",\"Rating\":7.97,\"Mechanics\":\"Dice Rolling, Grid Movement, Variable Player Powers\",\"YearPublished\":2018,\"CategoryType\":4},{\"Id\":80,\"Name\":\"Super Fantasy Brawl\",\"Rating\":7.39,\"Mechanics\":\"Action Retrieval, Hand Management, Set Collection\",\"YearPublished\":2018,\"CategoryType\":2},{\"Id\":81,\"Name\":\"The Cousins War\",\"Rating\":7.32,\"Mechanics\":\"Auction/Bidding, Worker Placement\",\"YearPublished\":2020,\"CategoryType\":4}]}"; ;
        var datasets = JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<JObject>>>(datasetsJson);

        foreach (var dataset in datasets)
        {
            var entityType = GetType(dataset.Key);
            var entities = dataset.Value
                .Select(j => j.ToObject(entityType))
                .ToArray();

            context.AddRange(entities);
        }

        context.SaveChanges();
    }

    private static Type GetType(string modelName)
    {
        var modelType = CurrentAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == modelName);

        Assert.IsNotNull(modelType, $"{modelName} model not found!");

        return modelType;
    }

    private static IServiceProvider ConfigureServices<TContext>(string databaseName)
        where TContext : DbContext
    {
        var services = ConfigureDbContext<TContext>(databaseName);

        var context = services.GetService<TContext>();

        try
        {
            context.Model.GetEntityTypes();
        }
        catch (InvalidOperationException ex) when (ex.Source == "Microsoft.EntityFrameworkCore.Proxies")
        {
            services = ConfigureDbContext<TContext>(databaseName, useLazyLoading: true);
        }

        return services;
    }

    private static IServiceProvider ConfigureDbContext<TContext>(string databaseName, bool useLazyLoading = false)
        where TContext : DbContext
    {
        var services = new ServiceCollection()
           .AddDbContext<TContext>(t => t
           .UseInMemoryDatabase(Guid.NewGuid().ToString())
           );

        var serviceProvider = services.BuildServiceProvider();
        return serviceProvider;
    }
}