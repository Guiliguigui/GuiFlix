import React, { useEffect, useState } from "react";
import QuestionComponent from "../../Components/QuestionComponent/QuestionComponent";
import './faqview.css';

export default function FAQView() {

    const [Question, SetQuestion] = useState([]);
    useEffect(() => {
        SetQuestion([{ Id: 1, Title: "Question 1", Answer: "fjzeifgezifbeziufgezui" }, { Id: 2, Title: "Question 2", Answer: "fezhfiezgfuozegfuoezguf" }]);
    }, [])


    return (
        <div className="FAQ">
            <h1>Frequently Ask View</h1>
            {Question.map((Q,index) => {
                return (
                    <QuestionComponent key={index} Question={Q} />)
            })}
        </div>
    );
}