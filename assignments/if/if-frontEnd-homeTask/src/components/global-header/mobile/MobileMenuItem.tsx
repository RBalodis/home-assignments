import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface MobileMenuItemProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLLIElement>['className'];
    isOpen?: boolean;
}

export const MobileMenuItem = ({
    children,
    className,
    isOpen,
}: MobileMenuItemProps) => {
    return (
        <li
            className={classnames('if mobile-menu-item', className, {
                'is-open': isOpen,
            })}
        >
            {children}
        </li>
    );
};
