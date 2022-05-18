import React, { useEffect, useState } from "react";
import './mediadetailscomponent.css';
import { faXmark, faPlayCircle, faCirclePlus } from "@fortawesome/free-solid-svg-icons";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { get } from "../../Service/Service";
import LoaderComponent from "../LoaderComponent/LoaderComponent";
import { useNavigate, Link } from "react-router-dom";
import LikeComponent from "../LikesComponent/LikeComponent";
import moment from 'moment';

export default function MediaDetailsComponent(props) {
    const [media, setMedia] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const navigate = useNavigate();
    useEffect(() => {
        get("Media/" + props.mediaId).then((res) => {
            setMedia(res.data);
            setIsLoading(false)
        })
    }, [])
    const close = () => {
        props.setIsDetails(false);
    }
    const goToPlayer = () => {
        navigate("/player", { state: media });
    }
    const pegiTypes = ["No Pegi", "Pegi 7",  "Pegi 13", "Pegi 16", "Pegi 18"]
    const pegi = pegiTypes[media.pegi]
    const date = new Date(media.realeaseDate)
    
    return (
        isLoading ? <LoaderComponent /> :
            <div className="mediaDetails">
                <div className="headerDetails">
                    <div className="titleDetails">{media.name} ({media.type})</div>
                    <button onClick={close} className="buttonClose"><FontAwesomeIcon icon={faXmark} /></button>
                </div>
                <div className="contentDetails" style={{ backgroundImage: "url(" + media.thumbnailLink + ")" }}>
                    <div className="descriptionDetails">{media.description}</div>
                    <div className="crewMembersDetails">With: {media.crewMembers.map((crewMember, index) => {
                        return (
                            <span key={index}> 
                                <Link to={"crewMember/"+crewMember.crewMember.id} className="linkDetails">{crewMember.crewMember.firstName} {crewMember.crewMember.lastName}</Link>
                                {index!=media.crewMembers.length-1?<>,&nbsp;</>:""}
                            </span>
                        )
                    })}
                    </div>
                    <div className="crewMembersDetails">Categories: {media.categories.map((category, index) => {
                        return (
                            <span key={index}> 
                                <Link to={"category/"+category.id} className="linkDetails">{category.name}</Link>
                                {index!=media.categories.length-1?<>,&nbsp;</>:""}
                            </span>
                        )
                    })}
                    </div>
                    <div className="bottomDetails">
                        <button className="buttonDetails" onClick={goToPlayer}><FontAwesomeIcon icon={faPlayCircle} /></button>
                        <LikeComponent profileSelected={props.profileSelected} mediaId={media.id}/>
                        <button className="buttonDetails" ><FontAwesomeIcon icon={faCirclePlus} /></button>
                        <div className="textDetails">{media.type=="Film"?media.duration:media.episodes.length+" Episodes"}</div>
                        <div className="textDetails">{pegi}</div>
                        <div className="textDetails">{moment(date).format('YYYY/MM/DD')}</div>
                    </div>
                </div>
            </div>
    )
}