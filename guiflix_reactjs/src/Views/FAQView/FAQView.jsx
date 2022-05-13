import React, { useEffect, useState } from "react";
import QuestionComponent from "../../Components/QuestionComponent/QuestionComponent";
import { get } from "../../Service/Service";
import './faqview.css';

export default function FAQView() {

    const [Question, SetQuestion] = useState([]);
    useEffect(() => {
        get("Question").then((res)=>{
            SetQuestion(res.data);
        })
    }, [])


    return (
        <div className="FAQ">
            <div className="titleFAQ">Frequently Ask Questions</div>
            {Question.map((Q,index) => {
                return (
                    <QuestionComponent key={index} Question={Q} />)
            })}
        </div>
    );
}