import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface DesktopMenuItemProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLLIElement>['className'];
}

export const DesktopMenuItem = ({
    children,
    className,
}: DesktopMenuItemProps) => {
    return (
        <li className={classnames('if desktop-menu-item', className)}>
            {children}
        </li>
    );
};
