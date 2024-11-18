import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface MobileMenuProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLUListElement>['className'];
}

export const MobileMenuList = ({ className, children }: MobileMenuProps) => {
    return (
        <ul className={classnames('if mobile-menu-list', className)}>
            {children}
        </ul>
    );
};
