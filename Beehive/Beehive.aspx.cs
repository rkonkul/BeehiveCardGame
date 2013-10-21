using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;
using System.IO;

namespace Beehive
{
<<<<<<< HEAD
    public class Score
    {
        public string name;
        public double time;

        public Score()
        {
        }

        public Score(string n, double t)
        {
            name = n;
            time = t;
        }
    }
    public partial class Beehive : System.Web.UI.Page
    {
        BeehiveGame game;
        List<Score> scores = new List<Score>();

        protected void Page_Load(object sender, EventArgs e)
        {

            //read in scores xml file located in project root
            string scoresXML = System.IO.File.ReadAllText(Server.MapPath("~") + "/scores.xml");
            scores = (List<Score>)SerializationUtils.DeserializeObject(scoresXML, typeof(List<Score>));

            scoresList.Items.Clear();
            for (int i = 0; i < scores.Count(); i++)
            {
                ListItem a = new ListItem();
                Score s = scores.ElementAt(i);
                a.Text = "" + (i + 1) + ". " + s.name + ": " + s.time;
                scoresList.Items.Add(a);
            }
=======
    public partial class Beehive : System.Web.UI.Page
    {
        BeehiveGame game;

        protected void Page_Load(object sender, EventArgs e)
        {
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
            updateView();
        }

        protected void updateView()
        {
<<<<<<< HEAD
=======

>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
            if (Session["gamedata"] == null)
            {
                game = new BeehiveGame();
                Session["gamedata"] = game;
            }
            else
            {
                game = (BeehiveGame)Session["gamedata"];
            }
<<<<<<< HEAD
            if (game.checkWinState())
            {
                nameInput.Visible = false;
                nameSubmit.Visible = false;
                for (int i = 1; i <= 6; i++)
                {
                    Image a = (Image)this.FindControl("dancingBee" + i);
                    a.Visible = true;
                }
                if (scores.ElementAt(scores.Count() - 1).time >= game.totalTime)
                {
                    System.Diagnostics.Debug.WriteLine("winstate");
                    nameInput.Visible = true;
                    nameSubmit.Visible = true;
                }
            }
            else
            {
                for (int i = 1; i <= 6; i++)
                {
                    Image a = (Image)this.FindControl("dancingBee" + i);
                    a.Visible = false;
                }
            }
=======
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
            for (int i = 1; i <= 6; i++)
            {
                ImageButton img = (ImageButton)this.FindControl("flower" + i);
                if (game.getFlowerStack(i).Count() == 0)
                {
<<<<<<< HEAD
                    img.ImageUrl = "~/resources/cards_png/blank.png";
                }
                else
                {
                    img.ImageUrl = "~/resources/cards_png/" + game.getFlowerStack(i).Peek().getImageFile();
=======
                    img.ImageUrl = "~/cards_png/blank.png";
                }
                else
                {
                    img.ImageUrl = "~/cards_png/" + game.getFlowerStack(i).Peek().getImageFile();
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
                }
                if (Session["selected"] == null)
                {
                    img.BorderWidth = 0;
                }
            }
            if (game.getBeehive().Count() > 0)
            {
<<<<<<< HEAD
                beehiveStack.ImageUrl = "~/resources/cards_png/" + game.getBeehive().Peek().getImageFile();
            }
            else
            {
                beehiveStack.ImageUrl = "~/resources/cards_png/blank.png";
            }
            if (game.getWorkingPile().Count() > 0)
            {
                workingStack.ImageUrl = "~/resources/cards_png/" + game.getWorkingPile().Peek().getImageFile();
=======
                beehiveStack.ImageUrl = "~/cards_png/" + game.getBeehive().Peek().getImageFile();
            }
            else
            {
                beehiveStack.ImageUrl = "~/cards_png/blank.png";
            }
            if (game.getWorkingPile().Count() > 0)
            {
                workingStack.ImageUrl = "~/cards_png/" + game.getWorkingPile().Peek().getImageFile();
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
            }
            else
            {
                workingStack.Visible = false;
            }

            if (game.getWorkingPile().Count() < 3)
            {
                hide1.Visible = false;
            }
            if (game.getWorkingPile().Count() < 2)
            {
                hide2.Visible = false;
            }
<<<<<<< HEAD
            if (game.getDeck().Count() < 1)
            {
                deck.ImageUrl = "~/resources/cards_png/blank.png";
            }
            else
            {
                deck.ImageUrl = "~/resources/cards_png/b1fv.png";
            }

            timeLabel.Text = "" + (DateTime.Now.ToFileTime() - game.startTime) / 10000000.0;
           // System.Diagnostics.Debug.WriteLine(game.printGameState());
=======
            System.Diagnostics.Debug.WriteLine(game.printGameState());
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
        }
        protected bool moveCardToFlower(ImageButton highlighted, int flower)
        {
            if (highlighted.ID.StartsWith("flower"))
            {
                return game.moveFlowerToFlower(Int32.Parse(highlighted.ID.Substring(highlighted.ID.Length - 1)), flower);
            }
            else if (highlighted.ID.Equals("beehiveStack"))
            {
                return game.moveBeehiveToFlower(flower);
            }
            else if (highlighted.ID.Equals("workingStack"))
            {
                return game.moveWorkingCardToFlower(flower);
            }
            return false;

        }

        protected void unSelectAnything()
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted != null)
            {
                if (highlighted.ID.StartsWith("flower"))
                {
                    removeHighlight(highlighted);
                }

                beehiveStack.BorderWidth = 0;
                workingStack.BorderWidth = 0;

                Session["selected"] = null;
                updateView();
            }
        }

        protected void Flower1_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower1);
                Session["selected"] = flower1;
            }
            else if (highlighted.ID.Equals("flower1"))
            {
                removeHighlight(flower1);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 1))
                {
                    unSelectAnything();
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("move to 1 failed");

                }
            }
            Session["gamedata"] = game;
            updateView();
        }

        protected void Flower2_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower2);
                Session["selected"] = flower2;
            }
            else if (highlighted.ID.Equals("flower2"))
            {
                removeHighlight(flower2);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 2))
                {
                    unSelectAnything();
                }
            }
            Session["gamedata"] = game;
            updateView();
        }

        protected void Flower3_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower3);
                Session["selected"] = flower3;
            }
            else if (highlighted.ID.Equals("flower3"))
            {
                removeHighlight(flower3);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 3))
                {
                    unSelectAnything();
                }
            }
            Session["gamedata"] = game;
            updateView();
        }

        protected void Flower4_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower4);
                Session["selected"] = flower4;
            }
            else if (highlighted.ID.Equals("flower4"))
            {
                removeHighlight(flower4);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 4))
                {
                    unSelectAnything();
                }
            }
            Session["gamedata"] = game;
            updateView();
        }

        protected void Flower5_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower5);
                Session["selected"] = flower5;
            }
            else if (highlighted.ID.Equals("flower5"))
            {
                removeHighlight(flower5);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 5))
                {
                    unSelectAnything();
                }
            }
            Session["gamedata"] = game;
            updateView();
        }

        protected void Flower6_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                setHighlight(flower6);
                Session["selected"] = flower6;
            }
            else if (highlighted.ID.Equals("flower6"))
            {
                removeHighlight(flower6);
                Session["selected"] = null;
            }
            else
            {
                if (moveCardToFlower(highlighted, 6))
                {
                    unSelectAnything();
                }
            }
            Session["gamedata"] = game;
            updateView();
        }
        protected void Beehive_Click(object sender, EventArgs e)
        {

            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                beehiveStack.BorderColor = System.Drawing.Color.Yellow;
                beehiveStack.BorderWidth = 3;
                Session["selected"] = beehiveStack;
            }
            else if (highlighted.ID.Equals("beehiveStack"))
            {
                beehiveStack.BorderWidth = 0;
                Session["selected"] = null;
            }
            else
            {
                //can't move cards onto this
            }
            Session["gamedata"] = game;
            updateView();
        }
        protected void Deck_Click(object sender, EventArgs e)
        {
            game.getDifferentWorkingPile();
            Session["gamedata"] = game;
            hide1.Visible = true;
            hide2.Visible = true;
            workingStack.Visible = true;
            updateView();
        }
        protected void Working_Click(object sender, EventArgs e)
        {
            ImageButton highlighted = (ImageButton)Session["selected"];
            if (highlighted == null)
            {
                workingStack.BorderColor = System.Drawing.Color.Yellow;
                workingStack.BorderWidth = 3;
                Session["selected"] = workingStack;
            }
            else if (highlighted.ID.Equals("workingStack"))
            {
                workingStack.BorderWidth = 0;
                Session["selected"] = null;
            }
            else
            {
                //can't move cards onto this
            }
            Session["gamedata"] = game;
            updateView();
        }

        private void setHighlight(ImageButton element)
        {
            element.BorderColor = System.Drawing.Color.Yellow;
            element.BorderWidth = 3;
            string s = element.Style["left"];
            s = s.Substring(0, s.Length - 2);
            int f = Int32.Parse(s) - 3;
            element.Style["left"] = f + "px";
            s = element.Style["top"];
            s = element.Style["top"];
            s = s.Substring(0, s.Length - 2);
            f = Int32.Parse(s) - 3;
            element.Style["top"] = f + "px";
            s = element.Style["top"];
        }

        private void removeHighlight(ImageButton element)
        {
            element.BorderWidth = 0;
            string s = element.Style["left"];
            s = s.Substring(0, s.Length - 2);
            int f = Int32.Parse(s) + 3;
            element.Style["left"] = f + "px";
            s = element.Style["top"];
            s = element.Style["top"];
            s = s.Substring(0, s.Length - 2);
            f = Int32.Parse(s) + 3;
            element.Style["top"] = f + "px";
            s = element.Style["top"];
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            game = new BeehiveGame();
            Session["gamedata"] = game;
            Response.Redirect(Request.RawUrl);
        }
<<<<<<< HEAD

        protected void nameSubmit_Click(object sender, EventArgs e)
        {
            if (game.playerWon())
            {
                scores.Add(new Score(nameInput.Text, game.totalTime));
                scores = scores.OrderBy(o => o.time).ToList();
                while (scores.Count() > 10)
                {
                    scores.RemoveAt(scores.Count() - 1);
                }
                string scoresXML = SerializationUtils.SerializeObject(scores);
                System.IO.File.WriteAllText(Server.MapPath("~") + "/scores.xml", scoresXML);
                game = new BeehiveGame();
                Session["gamedata"] = game;
                Response.Redirect(Request.RawUrl);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Error: User clicked name submit button but didnt win first");
            }
        }

=======
>>>>>>> 8f1b4a4b5b7063c62f23724d58ee6d04623ed156
    }
}
