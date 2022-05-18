import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import React, { useEffect, useState } from 'react';
import { get, post } from "../../Service/Service";
import { faHeart, faThumbsUp, faThumbsDown, faHeartCirclePlus } from "@fortawesome/free-solid-svg-icons";
import "./likecomponent.css";

export default function LikeComponent(props) {
    const LikeTypes = [faHeart, faThumbsUp, faThumbsDown]
    const [like, setLike] = useState(faHeartCirclePlus);
    
    useEffect(() => {
        props.profileSelected.likes.map((like) => {
            if(like.mediaId===props.mediaId)
                setLike(LikeTypes[like.type])
        })
    }, [])
    
    // const JWT = localStorage.getItem("GuiFlix_JWT");
    // function changeLike(type) {
    //     post("LikeMedia",
    //         {
    //             type,
    //             props.profileSelected.profileId,
    //             props.profileSelected.mediaId
    //         },
    //         {
    //             headers: { Authorization: `Bearer ${JWT}` }
    //         }
    //     ).then(res => {
    //         if (props.mediaId !== res.data.mediaId) {
    //             localStorage.setItem(LikeComponent);
    //         }
    //     }).catch((err) => {
    //         console.error(err.message);
    //     })
    // }

    return (
        <button className='like'>
            <FontAwesomeIcon icon={like} />
        </button>
    );
}


