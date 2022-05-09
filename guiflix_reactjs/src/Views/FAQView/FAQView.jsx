import React, { useEffect, useState } from "react";
import QuestionComponent from "../../Components/QuestionComponent/QuestionComponent";
import './faqview.css';

export default function FAQView() {

    const [Question, SetQuestion] = useState([]);
    useEffect(() => {
        SetQuestion([{ Id: 1, Title: "question 1", Answer: "answer" }, { Id: 2, Title: "Question 2", Answer: "Answer 2" }]);
    }, [])


    return (
        <div className="FAQ">
            {Question.map((Q,index) => {
                return (
                    <QuestionComponent key={index} Question={Q} />)
            })}
        </div>
    );
}