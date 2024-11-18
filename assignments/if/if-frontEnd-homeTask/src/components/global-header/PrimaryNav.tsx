import React, { ReactNode } from 'react';

interface PrimaryNavProps {
    children: ReactNode;
}

export const PrimaryNav = ({ children }: PrimaryNavProps) => {
    return <nav className="if primary">{children}</nav>;
};
