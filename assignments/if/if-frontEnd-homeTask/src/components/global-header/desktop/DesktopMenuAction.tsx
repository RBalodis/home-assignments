import React, { HTMLAttributes, ReactNode } from 'react';
import { NavLink } from 'react-router-dom';
import classnames from 'classnames';

interface DesktopMenuActionBaseProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLElement>['className'];
    onClick?: HTMLAttributes<HTMLElement>['onClick'];
}

export type DesktopMenuActionButtonProps = DesktopMenuActionBaseProps;

export type DesktopMenuActionLinkProps = {
    to: string;
} & DesktopMenuActionBaseProps;

export enum DesktopMenuActionAs {
    A = 'a',
    NAV_LINK = 'NavLink',
    BUTTON = 'button',
}

export type DesktopMenuActionProps = {
    as: DesktopMenuActionAs;
} & (DesktopMenuActionButtonProps | DesktopMenuActionLinkProps);

export const DesktopMenuActionButton = ({
    children,
    className,
    onClick,
}: DesktopMenuActionButtonProps) => {
    return (
        <button
            onClick={onClick}
            className={classnames('if desktop-menu-action', className)}
        >
            {children}
        </button>
    );
};

export const DesktopMenuActionLink = ({
    children,
    className,
    onClick,
    to,
}: DesktopMenuActionLinkProps) => {
    return (
        <NavLink
            to={to}
            onClick={onClick}
            className={({ isActive }) =>
                classnames(
                    'if desktop-menu-action',
                    className,
                    isActive ? 'is-active' : '',
                )
            }
        >
            {children}
        </NavLink>
    );
};

export const DesktopMenuActionExternalLink = ({
    children,
    className,
    onClick,
    to,
}: DesktopMenuActionLinkProps) => {
    return (
        <a
            onClick={onClick}
            href={to}
            target="_blank"
            rel={'noreferrer'}
            className={classnames('if desktop-menu-action', className)}
        >
            {children}
        </a>
    );
};

export const DesktopMenuAction = ({ as, ...props }: DesktopMenuActionProps) => {
    switch (as) {
        case DesktopMenuActionAs.BUTTON:
            return (
                <DesktopMenuActionButton
                    onClick={props.onClick}
                    className={props.className}
                >
                    {props.children}
                </DesktopMenuActionButton>
            );

        case DesktopMenuActionAs.NAV_LINK:
            return (
                <DesktopMenuActionLink
                    onClick={props.onClick}
                    to={(props as DesktopMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </DesktopMenuActionLink>
            );

        case DesktopMenuActionAs.A:
            return (
                <DesktopMenuActionExternalLink
                    onClick={props.onClick}
                    to={(props as DesktopMenuActionLinkProps).to}
                    className={props.className}
                >
                    {props.children}
                </DesktopMenuActionExternalLink>
            );
    }
};
