import React from 'react';
import { Header } from './Header';
import { Content } from './Content';

export const Page = () => {
    return (
        <div className="if app">
            <Header />
            <Content />
        </div>
    );
};
