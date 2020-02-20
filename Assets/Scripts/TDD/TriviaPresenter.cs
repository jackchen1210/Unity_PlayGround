public class TriviaPresenter
{
    public int Score{get;private set;}

    public TriviaPresenter(){
        Score = 0;
    }

    public TriviaPresenter(TriviaGameView triviaGameView){

    }

    public void SetAnswer(string _answer){

        if(_answer.Equals("ok")){
            Score++;
        }
        
    }
}