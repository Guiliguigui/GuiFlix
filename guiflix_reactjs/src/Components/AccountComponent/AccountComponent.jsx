import React from 'react';
import { useLocalStorage } from '../../useLocalStorage';

export default function AccountComponent() {
    const account=()=>{
        const [email, setEmail]=useLocalStorage();
    }

    return (
        <div>

        </div>
    );
}

