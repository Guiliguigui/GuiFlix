import React, { useEffect, useState } from "react";
import QuestionComponent from "../../Components/QuestionComponent/QuestionComponent";
import { get } from "../../Service/Service";
import './faqview.css';

export default function FAQView() {

    const [Question, SetQuestion] = useState([]);
    useEffect(() => {
        /*get("Question").then((res)=>{
            SetQuestion(res.data);
        })*/
        SetQuestion([{Id:1,Title:"Question 1",Answer:"fhdsiufdsfsfgezuifgeufgi"},{Id:2,Title:"Question 2",Answer:"fhdsiufgezuifgeugfgfgfgi"}]);
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