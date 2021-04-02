using System.Collections.Generic;

namespace Models
{
    public class stopWords
    {
        public bool isStopWord(string kelime)
        {
            bool sonuc = false;
            foreach(string s in list)
            {
                if(kelime.ToLower().Equals(s))
                {
                    sonuc = true;
                    break;
                }
            }
            return sonuc;
        }
        List<string> list = new List<string>()
            {
"a",
"able",
"about",
"above",
"according",
"accordingly",
"across",
"actually",
"after",
"afterwards",
"again",
"against",
"ain't",
"all",
"allow",
"allows",
"almost",
"alone",
"along",
"already",
"also",
"although",
"always",
"am",
"among",
"amongst",
"an",
"and",
"another",
"any",
"anybody",
"anyhow",
"anyone",
"anything",
"anyway",
"anyways",
"anywhere",
"apart",
"appear",
"appreciate",
"appropriate",
"are",
"aren't",
"around",
"as",
"a's",
"aside",
"ask",
"asking",
"associated",
"at",
"available",
"away",
"awfully",
"be",
"became",
"because",
"become",
"becomes",
"becoming",
"been",
"before",
"beforehand",
"behind",
"being",
"believe",
"below",
"beside",
"besides",
"best",
"better",
"between",
"beyond",
"both",
"brief",
"but",
"by",
"came",
"can",
"cannot",
"cant",
"can't",
"cause",
"causes",
"certain",
"certainly",
"changes",
"clearly",
"c'mon",
"co",
"com",
"come",
"comes",
"concerning",
"consequently",
"consider",
"considering",
"contain",
"containing",
"contains",
"corresponding",
"could",
"couldn't",
"course",
"c's",
"currently",
"definitely",
"described",
"despite",
"did",
"didn't",
"different",
"do",
"does",
"doesn't",
"doing",
"done",
"don't",
"down",
"downwards",
"during",
"each",
"edu",
"eg",
"eight",
"either",
"else",
"elsewhere",
"enough",
"entirely",
"especially",
"et",
"etc",
"even",
"ever",
"every",
"everybody",
"everyone",
"everything",
"everywhere",
"ex",
"exactly",
"example",
"except",
"far",
"few",
"fifth",
"first",
"five",
"followed",
"following",
"follows",
"for",
"former",
"formerly",
"forth",
"four",
"from",
"further",
"furthermore",
"get",
"gets",
"getting",
"given",
"gives",
"go",
"goes",
"going",
"gone",
"got",
"gotten",
"greetings",
"had",
"hadn't",
"happens",
"hardly",
"has",
"hasn't",
"have",
"haven't",
"having",
"he",
"he'd",
"he'll",
"hello",
"help",
"hence",
"her",
"here",
"hereafter",
"hereby",
"herein",
"here's",
"hereupon",
"hers",
"herself",
"he's",
"hi",
"him",
"himself",
"his",
"hither",
"hopefully",
"how",
"howbeit",
"however",
"how's",
"i",
"i'd",
"ie",
"if",
"ignored",
"i'll",
"i'm",
"immediate",
"in",
"inasmuch",
"inc",
"indeed",
"indicate",
"indicated",
"indicates",
"inner",
"insofar",
"instead",
"into",
"inward",
"is",
"isn't",
"it",
"it'd",
"it'll",
"its",
"it's",
"itself",
"i've",
"just",
"keep",
"keeps",
"kept",
"know",
"known",
"knows",
"last",
"lately",
"later",
"latter",
"latterly",
"least",
"less",
"lest",
"let",
"let's",
"like",
"liked",
"likely",
"little",
"look",
"looking",
"looks",
"ltd",
"mainly",
"many",
"may",
"maybe",
"me",
"mean",
"meanwhile",
"merely",
"might",
"more",
"moreover",
"most",
"mostly",
"much",
"must",
"mustn't",
"my",
"myself",
"name",
"namely",
"nd",
"near",
"nearly",
"necessary",
"need",
"needs",
"neither",
"never",
"nevertheless",
"new",
"next",
"nine",
"no",
"nobody",
"non",
"none",
"noone",
"nor",
"normally",
"not",
"nothing",
"novel",
"now",
"nowhere",
"obviously",
"of",
"off",
"often",
"oh",
"ok",
"okay",
"old",
"on",
"once",
"one",
"ones",
"only",
"onto",
"or",
"other",
"others",
"otherwise",
"ought",
"our",
"ours",
"ourselves",
"out",
"outside",
"over",
"overall",
"own",
"particular",
"particularly",
"per",
"perhaps",
"placed",
"please",
"plus",
"possible",
"presumably",
"probably",
"provides",
"que",
"quite",
"qv",
"rather",
"rd",
"re",
"really",
"reasonably",
"regarding",
"regardless",
"regards",
"relatively",
"respectively",
"right",
"said",
"same",
"saw",
"say",
"saying",
"says",
"second",
"secondly",
"see",
"seeing",
"seem",
"seemed",
"seeming",
"seems",
"seen",
"self",
"selves",
"sensible",
"sent",
"serious",
"seriously",
"seven",
"several",
"shall",
"shan't",
"she",
"she'd",
"she'll",
"she's",
"should",
"shouldn't",
"since",
"six",
"so",
"some",
"somebody",
"somehow",
"someone",
"something",
"sometime",
"sometimes",
"somewhat",
"somewhere",
"soon",
"sorry",
"specified",
"specify",
"specifying",
"still",
"sub",
"such",
"sup",
"sure",
"take",
"taken",
"tell",
"tends",
"th",
"than",
"thank",
"thanks",
"thanx",
"that",
"thats",
"that's",
"the",
"their",
"theirs",
"them",
"themselves",
"then",
"thence",
"there",
"thereafter",
"thereby",
"therefore",
"therein",
"theres",
"there's",
"thereupon",
"these",
"they",
"they'd",
"they'll",
"they're",
"they've",
"think",
"third",
"this",
"thorough",
"thoroughly",
"those",
"though",
"three",
"through",
"throughout",
"thru",
"thus",
"to",
"together",
"too",
"took",
"toward",
"towards",
"tried",
"tries",
"truly",
"try",
"trying",
"t's",
"twice",
"two",
"un",
"under",
"unfortunately",
"unless",
"unlikely",
"until",
"unto",
"up",
"upon",
"us",
"use",
"used",
"useful",
"uses",
"using",
"usually",
"value",
"various",
"very",
"via",
"viz",
"vs",
"want",
"wants",
"was",
"wasn't",
"way",
"we",
"we'd",
"welcome",
"well",
"we'll",
"went",
"were",
"we're",
"weren't",
"we've",
"what",
"whatever",
"what's",
"when",
"whence",
"whenever",
"when's",
"where",
"whereafter",
"whereas",
"whereby",
"wherein",
"where's",
"whereupon",
"wherever",
"whether",
"which",
"while",
"whither",
"who",
"whoever",
"whole",
"whom",
"who's",
"whose",
"why",
"why's",
"will",
"willing",
"wish",
"with",
"within",
"without",
"wonder",
"won't",
"would",
"wouldn't",
"yes",
"yet",
"you",
"you'd",
"you'll",
"your",
"you're",
"yours",
"yourself",
"yourselves",
"you've",
"zero",
"acaba",
"altmış",
"altı",
"ama",
"ancak",
"arada",
"aslında",
"ayrıca",
"bana",
"bazı",
"belki",
"ben",
"benden",
"beni",
"benim",
"beri",
"beş",
"bile",
"bin",
"bir",
"birçok",
"biri",
"birkaç",
"birkez",
"birşey",
"birşeyi",
"biz",
"bize",
"bizden",
"bizi",
"bizim",
"böyle",
"böylece",
"bu",
"buna",
"bunda",
"bundan",
"bunlar",
"bunları",
"bunların",
"bunu",
"bunun",
"burada",
"çok",
"çünkü",
"da",
"daha",
"dahi",
"de",
"defa",
"değil",
"diğer",
"diye",
"doksan",
"dokuz",
"dolayı",
"dolayısıyla",
"dört",
"edecek",
"eden",
"ederek",
"edilecek",
"ediliyor",
"edilmesi",
"ediyor",
"eğer",
"elli",
"en",
"etmesi",
"etti",
"ettiği",
"ettiğini",
"gibi",
"göre",
"halen",
"hangi",
"hatta",
"hem",
"henüz",
"hep",
"hepsi",
"her",
"herhangi",
"herkesin",
"hiç",
"hiçbir",
"için",
"iki",
"ile",
"ilgili",
"ise",
"işte",
"itibaren",
"itibariyle",
"kadar",
"karşın",
"katrilyon",
"kendi",
"kendilerine",
"kendini",
"kendisi",
"kendisine",
"kendisini",
"kez",
"ki",
"kim",
"kimden",
"kime",
"kimi",
"kimse",
"kırk",
"milyar",
"milyon",
"mu",
"mü",
"mı",
"nasıl",
"ne",
"neden",
"nedenle",
"nerde",
"nerede",
"nereye",
"niye",
"niçin",
"o",
"olan",
"olarak",
"oldu",
"olduğu",
"olduğunu",
"olduklarını",
"olmadı",
"olmadığı",
"olmak",
"olması",
"olmayan",
"olmaz",
"olsa",
"olsun",
"olup",
"olur",
"olursa",
"oluyor",
"on",
"ona",
"ondan",
"onlar",
"onlardan",
"onları",
"onların",
"onu",
"onun",
"otuz",
"oysa",
"öyle",
"pek",
"rağmen",
"sadece",
"sanki",
"sekiz",
"seksen",
"sen",
"senden",
"seni",
"senin",
"siz",
"sizden",
"sizi",
"sizin",
"şey",
"şeyden",
"şeyi",
"şeyler",
"şöyle",
"şu",
"şuna",
"şunda",
"şundan",
"şunları",
"şunu",
"tarafından",
"trilyon",
"tüm",
"üç",
"üzere",
"var",
"vardı",
"ve",
"veya",
"ya",
"yani",
"yapacak",
"yapılan",
"yapılması",
"yapıyor",
"yapmak",
"yaptı",
"yaptığı",
"yaptığını",
"yaptıkları",
"yedi",
"yerine",
"yetmiş",
"yine",
"yirmi",
"yoksa",
"yüz",
"zaten",
"altmış",
"altı",
"bazı",
"beş",
"birşey",
"birşeyi",
"kırk",
"mı",
"nasıl",
"onları",
"onların",
"yetmiş",
"şey",
"şeyden",
"şeyi",
"şeyler",
"şu",
"şuna",
"şunda",
"şundan",
"şunu"
            };
    }
}