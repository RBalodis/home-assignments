import React, { ReactNode } from 'react';
import { NavLink } from 'react-router-dom';

interface GlobalHeaderProps {
    children: ReactNode;
}

export const GlobalHeader = ({ children }: GlobalHeaderProps) => {
    return (
        <header className="if global-header">
            <NavLink to="/" className="if axe skip-to-content">
                Skip to content
            </NavLink>

            {children}
        </header>
    );
};
