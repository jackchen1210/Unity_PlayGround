using NUnit.Framework;
using NSubstitute;

[TestFixture]
public class TriviaPresenterTest 
{
    [Test]
    public void When_Right_Answer_Score_Increased(){

        //Given
        TriviaPresenter triviaPresenter = new TriviaPresenter();
        var initScore = triviaPresenter.Score;

        //When
        triviaPresenter.SetAnswer("ok");

        //Then
        Assert.AreEqual(initScore+1,triviaPresenter.Score);
    }

    [Test]
    public void When_Right_Answer_Shows_Positive_Feedback(){

        //Given
        TriviaGameView triviaGameView = Substitute.For<TriviaGameView>();
        TriviaPresenter triviaPresenter = new TriviaPresenter(triviaGameView);

        //When
        triviaPresenter.SetAnswer("ok");

        //Then
        triviaGameView.Received(1).ShowPositiveFeedBack();
    }
}
