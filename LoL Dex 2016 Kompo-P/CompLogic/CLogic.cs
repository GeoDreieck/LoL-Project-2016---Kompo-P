using System;
using System.Collections.Generic;
using System.Data;

using CompData;


namespace CompLogic
{

    internal class CLogic : ILogic
    {
        //Erzeugen von Klassenspezifischen Variablen
        #region fields
        private IDatabase _iDatabase;
        string _imagedirectorypath;
        #endregion

        #region ctor
        public CLogic(IDatabase iDatabase, string imgdirpath)
        {
            //Datenbank-Abhängigkeit wird eingebunden
            _iDatabase = iDatabase;

            //Pfad zum Image-Ordner wird abgespeichert
            _imagedirectorypath = imgdirpath;
        }
        #endregion

        #region get/set
        //Return _imagedirectorypath
        public string Imagdirectorypath()
        {
            return _imagedirectorypath;
        }
        #endregion

        #region methods
        // Implmentierung Interfaces

        #region Champs
        //Hole Champ-ID und -Namen aus dem Champs-Tabel des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetChampNames()
        {
            int length = _iDatabase.DataSet().Tables["Champs"].Rows.Count;
            string[,] champnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                champnames[i, 0] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[0].ToString();
                champnames[i, 1] = _iDatabase.DataSet().Tables["Champs"].Rows[i].ItemArray[1].ToString();
            }

            return champnames;
        }

        //Hole spezifische Champ-Infos aus dem Champs-Tabel des Datasets und gebe sie als string zurück
        public string GetChampInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[infonumber].ToString();
        }

        //Hole die ID der ersten Fähigkeit des Champs und die Anzahl der Fähigkeiten aus dem Champs-Tabel des Datasets 
        //und hole damit aus dem Ability-Table alle Infos zu den dem Champ zugeordneten Fähigkeiten
        public List<List<string>> GetAbilitiesData(int id)
        {
            List<List<string>> abilitylist = new List<List<string>>();
            int firstAbilityID = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[4].ToString());
            int numberofAbilitys = Convert.ToInt32(_iDatabase.DataSet().Tables["Champs"].Rows[id].ItemArray[5].ToString());

            for (int i = 0; i < numberofAbilitys; i++)
            {
                List<string> ability = new List<string>();
                for (int i2 = 0; i2 < 5; i2++)
                {
                    ability.Add(_iDatabase.DataSet().Tables["Abilities"].Rows[firstAbilityID + i].ItemArray[i2 + 1].ToString());
                }
                abilitylist.Add(ability);
            }

            return abilitylist;
        }
        #endregion

        #region Items
        //Hole Item-ID und -Namen aus dem Items-Table des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetItemNames()
        {
            int length = _iDatabase.DataSet().Tables["Items"].Rows.Count;
            string[,] itemnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                itemnames[i, 0] = _iDatabase.DataSet().Tables["Items"].Rows[i].ItemArray[0].ToString();
                itemnames[i, 1] = _iDatabase.DataSet().Tables["Items"].Rows[i].ItemArray[1].ToString();
            }

            return itemnames;
        }

        //Hole spezifische Item-Infos aus dem Items-Table des Dataset und gebe sie als string zurück
        public string GetItemInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Items"].Rows[id].ItemArray[infonumber].ToString();
        }

        //Hole dir über den Select-Befehl eine Auswahl an Item-Zugehörigkeiten aus dem ItemAbuildsIntoItemB-Table des Dataset 
        //basierend auf der ID eines Items aus dem Items-Table und gebe sie als String-Liste zurück
        public List<List<string>> GetIconsforParentitems(int id)
        {
            List<List<string>> iconlist = new List<List<string>>();
            DataRow[] result = _iDatabase.DataSet().Tables["ItemAbuildsIntoItemB"].Select("ItemAID = " + id);

            for(int i = 0; i < result.Length; i++)
            {
                List<string> data = new List<string>();
                data.Add(Convert.ToString(Convert.ToInt32(result[i].ItemArray[1].ToString())-1));
                data.Add(_iDatabase.DataSet().Tables["Items"].Rows[Convert.ToInt32(result[i].ItemArray[1].ToString()) - 1].ItemArray[5].ToString());
                iconlist.Add(data);
            }

            return iconlist; 
        }
        #endregion

        #region Runes
        //Hole alle Runes-ID und -Namen aus dem Runes-Table des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetAllRunesNames()
        {
            int length = _iDatabase.DataSet().Tables["Runes"].Rows.Count;
            string[,] runesnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                runesnames[i, 0] = _iDatabase.DataSet().Tables["Runes"].Rows[i].ItemArray[0].ToString();
                runesnames[i, 1] = _iDatabase.DataSet().Tables["Runes"].Rows[i].ItemArray[1].ToString();
            }

            return runesnames;
        }

        //Hole bestimmte Runes-ID und -Namen aus dem Runes-Table des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetSelectedRunesNames(string kind, string level)
        {
            string[,] RunesNamesIDPairArray;

            int length;
            if (level == "Stufe 3")
                level = "3";
            if (level == "Stufe 2")
                level = "2";
            if (level == "Stufe 1")
                level = "1";

            DataRow[] result;
            if (kind == "Alle" && level != "Alle")
                result = _iDatabase.DataSet().Tables["Runes"].Select("TierLevel = " + level);
            else
                if(kind != "Alle" && level == "Alle")
                    result = _iDatabase.DataSet().Tables["Runes"].Select("RuneKind = '" + kind+ "'");
                else 
                     if(kind != "Alle" && level != "Alle")
                     {
                         result = _iDatabase.DataSet().Tables["Runes"].Select("(RuneKind = '" + kind + "') AND (TierLevel = " + level+ ")");
                         
                     }
                     else
                     {
                        result = _iDatabase.DataSet().Tables["Runes"].Select();
                     }

                length = result.Length;

            RunesNamesIDPairArray = new string[length, 2];
            for (int i = 0; i < length; i++)
            {
                RunesNamesIDPairArray[i, 0] = result[i].ItemArray[0].ToString();
                RunesNamesIDPairArray[i, 1] = result[i].ItemArray[1].ToString();
            }
            return RunesNamesIDPairArray;
        }

        //Hole spezifische Runes-Infos aus dem Runes-Table des Dataset und gebe sie als string zurück
        public string GetRunesInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Runes"].Rows[id].ItemArray[infonumber].ToString();
        }
        #endregion

        #region Masterie
        //Hole spezifische Image-Name des gewünschten Masterietrees aus dem Masterietree-Table des Dataset und gebe ihn als string zurück
        public string GetTree(int treenumber)
        {
            return _iDatabase.DataSet().Tables["Masterietrees"].Rows[treenumber-1].ItemArray[2].ToString();
        }

        //Hole spezifische Masterie-Infos aus dem Masteries-Table des Dataset und gebe sie als string zurück
        public string GetMasterieInfo(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Masterie"].Rows[id].ItemArray[infonumber].ToString();
        }
        #endregion

        #region Summonerspells
        //Hole SummonerSpells-ID und -Namen aus SummonerSpells-Table des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetSummonerSpellsNames()
        {
            int length = _iDatabase.DataSet().Tables["SummonerSpells"].Rows.Count;
            string[,] summonerspellsnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                summonerspellsnames[i, 0] = _iDatabase.DataSet().Tables["SummonerSpells"].Rows[i].ItemArray[0].ToString();
                summonerspellsnames[i, 1] = _iDatabase.DataSet().Tables["SummonerSpells"].Rows[i].ItemArray[1].ToString();
            }

            return summonerspellsnames;
        }

        //Hole spezifische Summonerspells-Infos aus dem SummonerSpells.Table des Dataset und gebe sie als string zurück
        public string GetSummonerSpellsInfo(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["SummonerSpells"].Rows[id].ItemArray[infonumber].ToString();
        }
        #endregion

        #region Creeps
        //Hole Creeps-ID und -Namen aus dem Creeps-Table des Dataset und gebe sie in einem 2-dimensionalen String-Array zurück
        public string[,] GetCreepsNames()
        {
            int length = _iDatabase.DataSet().Tables["Creeps"].Rows.Count;
            string[,] creepnames = new string[length, 2];

            for (int i = 0; i < length; i++)
            {
                creepnames[i, 0] = _iDatabase.DataSet().Tables["Creeps"].Rows[i].ItemArray[0].ToString();
                creepnames[i, 1] = _iDatabase.DataSet().Tables["Creeps"].Rows[i].ItemArray[1].ToString();
            }

            return creepnames;
        }

        //Hole spezifische Creep-Infos aus dem Creeps-Table des Dataset und gebe sie als string zurück
        public string GetCreepInfos(int id, int infonumber)
        {
            return _iDatabase.DataSet().Tables["Creeps"].Rows[id].ItemArray[infonumber].ToString();
        }
        #endregion
        #endregion
    }
}