import React, { useEffect, useState } from "react";
import LoaderComponent from "../../Components/LoaderComponent/LoaderComponent";
import QuestionComponent from "../../Components/QuestionComponent/QuestionComponent";
import { get } from "../../Service/Service";
import './faqview.css';

export default function FAQView() {

    const [Question, setQuestion] = useState([]);
    const [isLoading,setIsLoading] = useState(true);
    useEffect(() => {
        get("Question").then((res)=>{
            setQuestion(res.data);
            setIsLoading(false);
        })
    }, [])


    return (
        <div className="FAQ">
            <div className="titleFAQ">Frequently Ask Questions</div>
            {isLoading? <LoaderComponent/> 
            : 
            Question.map((Q,index) => {
                return (
                    <QuestionComponent key={index} Question={Q} />)
            })}
        </div>
    );
}