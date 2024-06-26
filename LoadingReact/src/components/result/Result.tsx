import React from "react";
import { useLocation, useNavigate } from "react-router-dom";
import { IAnswer } from "../../interfaces/IAnswer";

function NextQuestionAvailable(): boolean {
  const questionCount = parseInt(localStorage.getItem("questionCount") as string);
  let currentIndex = parseInt(localStorage.getItem("questionIndex") as string);

  if (questionCount === currentIndex || questionCount === 0) {
    return false;
  } else {
    currentIndex++;
    localStorage.setItem("questionIndex", currentIndex.toString());

    return true;
  }
}

const Result: React.FC = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const {
    question,
    answers,
    selectedAnswer,
  }: { question: string; answers: IAnswer[]; selectedAnswer: IAnswer } =
    location.state;

  const answerCounts = answers.reduce(
    (acc: { [key: string]: number }, answer) => {
      acc[answer.answerText] = answer.id === selectedAnswer.id ? 1 : 0;
      return acc;
    },
    {}
  );

  const totalAnswers = 1;

  const handleClick = (): void => {
    if (NextQuestionAvailable()) {
      navigate("/wait");
    } else {
      navigate("/feedback");
    }
  };

  const formatPrecentage = (count: number, total: number) => {
    const percentage = (count / total) * 100;
    return percentage % 1 === 0 ? percentage.toString() : percentage.toFixed(2);
  };

  return (
    <article
      onClick={handleClick}
      className="d-flex justify-content-center align-items-center vh-100"
    >
      <section className="text-center rounded shadow p-4">
        <h1>{question}</h1>
        <section className="row">
          {Object.entries(answerCounts).map(([label, count]) => (
            <div key={label}>
              <p className="card3 answer-box text-center rounded w-100 p-3">
                {label}: {formatPrecentage(count, totalAnswers)}%
              </p>
            </div>
          ))}
        </section>
        <div>
          <div id="graph"></div>
        </div>{" "}
      </section>
    </article>
  );
};

export default Result;
