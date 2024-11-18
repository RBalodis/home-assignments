import React, { ReactNode } from 'react';

interface SecondaryNavProps {
    children: ReactNode;
}

export const SecondaryNav = ({ children }: SecondaryNavProps) => {
    return <nav className="if secondary">{children}</nav>;
};
